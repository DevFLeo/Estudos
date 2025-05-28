// Ideia de semaforo em Java

import java.util.Scanner;


// Public class Semaforo com semaforo funcional
public class Semaforo {
    public static final int VERDE = 1;
    public static final int AMARELO = 2;
    public static final int VERMELHO = 3;
    public static final int PEDESTRE = 4;

    public static final int TEMPO_VERDE = 10;
    public static final int TEMPO_AMARELO = 3;
    public static final int TEMPO_VERMELHO = 10;
    public static final int TEMPO_PEDESTRE = 5;

    private int estadoAtual = VERDE;
    private boolean emExecucao = false;
    private boolean mostrarMenu = true;

    public static void main(String[] args) {
        Semaforo semaforo = new Semaforo();
        semaforo.executarMenu();
    }

    public void executarMenu() {
        Scanner scanner = new Scanner(System.in);
        int opcao = -1;

        do {
            if (mostrarMenu) imprimirMenu();

            try {
                System.out.print("Escolha uma opção: ");
                opcao = Integer.parseInt(scanner.nextLine());
            } catch (NumberFormatException e) {
                System.out.println("Opção inválida. Digite um número.");
                continue;
            }

            switch (opcao) {
                case 1:
                    if (!emExecucao) {
                        new Thread(() -> modoAutomatico()).start();
                    } else {
                        System.out.println("Modo automático já está em execução.");
                    }
                    mostrarMenu = false;
                    break;
                case 2:
                    pararModoAutomatico();
                    mostrarMenu = false;
                    break;
                case 3:
                    executarModoManual();
                    mostrarMenu = false;
                    break;
                case 4:
                    estadoAtual = VERDE;
                    System.out.println("Estado redefinido para VERDE.");
                    mostrarMenu = false;
                    break;
                case 5:
                    if (emExecucao) {
                        System.out.println("Modo automático está EM EXECUÇÃO.");
                    } else {
                        System.out.println("Modo automático está PARADO.");
                    }
                    mostrarMenu = false;
                    break;
                case 6:
                    mostrarTempoRestanteSimulado();
                    mostrarMenu = false;
                    break;
                case 7:
                    mostrarMenu = true;
                    break;
                case 0:
                    pararModoAutomatico();
                    System.out.println("Encerrando aplicação...");
                    break;
                default:
                    System.out.println("Opção inválida.");
            }
        } while (opcao != 0);

        scanner.close();
    }

    
// Método para imprimir o menu de opções, porem , não tem como iniciar numero 3 em loop sem dar erro.
    private void imprimirMenu() {
        System.out.println("\nMENU:");
        System.out.println("1 - Iniciar modo automático");
        System.out.println("2 - Parar modo automático");
        System.out.println("3 - Executar modo manual (um ciclo)");
        System.out.println("4 - Redefinir semáforo para VERDE");
        System.out.println("5 - Verificar se modo automático está em execução");
        System.out.println("6 - Mostrar tempo restante no estado atual");
        System.out.println("7 - Mostrar menu novamente");
        System.out.println("0 - Sair");
    }

    private void modoAutomatico() {
        emExecucao = true;
        while (emExecucao) {
            executarCiclo();
        }
        System.out.println("Modo automático parado.");
    }

    private void executarModoManual() {
        System.out.println("Executando ciclo manual:");
        executarCiclo();
    }

    private void executarCiclo() {
        switch (estadoAtual) {
            case VERDE:
                System.out.println("Semáforo VERDE. Carros podem passar.");
                esperar(TEMPO_VERDE);
                estadoAtual = AMARELO;
                break;
            case AMARELO:
                System.out.println("Semáforo AMARELO. Atenção.");
                esperar(TEMPO_AMARELO);
                estadoAtual = VERMELHO;
                break;
            case VERMELHO:
                System.out.println("Semáforo VERMELHO. Carros devem parar.");
                esperar(TEMPO_VERMELHO);
                estadoAtual = PEDESTRE;
                break;
            case PEDESTRE:
                System.out.println("Semáforo PEDESTRE. Pedestres podem atravessar.");
                esperar(TEMPO_PEDESTRE);
                estadoAtual = VERDE;
                break;
        }
    }

    private void esperar(int segundos) {
        try {
            for (int i = segundos; i > 0; i--) {
                System.out.println("... " + i + "s");
                Thread.sleep(1000);
            }
        } catch (InterruptedException e) {
            System.out.println("Interrompido.");
        }
    }

    public void pararModoAutomatico() {
        emExecucao = false;
    }

    private void mostrarTempoRestanteSimulado() {
        int tempo = switch (estadoAtual) {
            case VERDE -> TEMPO_VERDE;
            case AMARELO -> TEMPO_AMARELO;
            case VERMELHO -> TEMPO_VERMELHO;
            case PEDESTRE -> TEMPO_PEDESTRE;
            default -> 0;
        };
        System.out.println("Tempo restante estimado no estado atual (" + estadoAtualToString() + "): ~" + tempo + " segundos.");
    }

    private String estadoAtualToString() {
        return switch (estadoAtual) {
            case VERDE -> "VERDE";
            case AMARELO -> "AMARELO";
            case VERMELHO -> "VERMELHO";
            case PEDESTRE -> "PEDESTRE";
            default -> "DESCONHECIDO";
        };
    }
}

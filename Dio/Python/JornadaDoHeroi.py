# --- DOMÍNIO INTERATIVO: CLASSIFICADOR JUJUTSU ---

# A lista de feiticeiros e a função de classificação continuam as mesmas.
escola_jujutsu = [
    {"nome": "Yuta Okkotsu, Fala: Copio o teu mundo Só não prometo sem dor!", "xp": 10000},
    {"nome": "Kinji Hakari, Fala: Hoje eu tô com sorte! Por 4 minutos, Sou imune a morte!", "xp": 9800},
    {"nome": "Maki Zen'in, Fala: Eu tô tipo iPhone Eu vivo sem energia!", "xp": 9500},
    {"nome": "Aoi Todo com 530.000 de QI, Fala: Esse seu jeito idol conquistou o meu coração! Por você, eu compro até um terreno no Maranhão!", "xp": 9300},
    {"nome": "Toge Inumaki, Fala: Salmão", "xp": 8800},
    {"nome": "Kento Nanami, Fala: Eu tô de hora extra!E nessa maldição eu vou meter a peixeira!", "xp": 8500},
    {"nome": "Toji Fushiguro, Fala: Olha quem voltou pra essa parada. Quem é o mais forte daqui? Que eu vou entupir de pancada.", "xp": 9600},
    {"nome": "Dagon, Fala: Onde vai ser o fim de semana. Não vai ter nenhum engano: Você vai pro litoral, e eu vou atrás litorando", "xp": 9900},
    {"nome": "Megumi Fushiguro, Fala: Se as sombras me fazer cair Então vou levantar! General Divino: Mahoraga Eu vou invocar! ", "xp": 7800},
    {"nome": "Yuji Itadori, Fala: Parece até que não entende Toma soco na cara! Punho Divergente!", "xp": 7600},
    {"nome": "Panda, que DEFINITIVAMENTE não é um Panda", "xp": 7100},
    {"nome": "Nobara Kugisaki, Fala: Pá Pá Pá! Pá Pá Pá! Do meu boneco de palha Não vai ter como escapar!", "xp": 6800},
    {"nome": "Satoru Gojo, O Mais Forte, O Mais Honrado e mais belo", "xp": 99999}
]

def classificar_feiticeiro(xp):
    if xp <= 1000: return "Ferro"
    elif xp <= 2000: return "Bronze"
    elif xp <= 5000: return "Prata"
    elif xp <= 7000: return "Ouro"
    elif xp <= 8000: return "Platina"
    elif xp <= 9000: return "Ascendente"
    elif xp <= 10000: return "Imortal"
    else: return "Radiante"

# O nosso laço principal
while True:
    print("\n--- EXPANSÃO DE DOMINIO: MENU DE ANÁLISE DE FEITICEIROS ---")
    print("Quem você gostaria de analisar?")
    
    for indice, feiticeiro in enumerate(escola_jujutsu):
        print(f"  {indice + 1} - {feiticeiro['nome']}")
    
    print("\n  --- Opções Especiais ---")
    print("  99 - Mostrar o relatório completo de TODOS os feiticeiros")
    print("  0  - Sair do programa")
    
    escolha = input("\nDigite o número da sua opção: ")

    if escolha == '0':
        print("\nEntendido! Encerrando o domínio.")
        break
    
    elif escolha == '99':
        print("\n==========================================================")
        print("Aqui está o relatório completo da turma, como o senhor pediu!")
        print("O potencial de cada um, escaneado pela expansão de DOMINGO")
        print("----------------------------------------------------------")
        for f in escola_jujutsu:
            nivel = classificar_feiticeiro(f['xp'])
            print(f"-> O Feiticeiro **{f['nome']}** foi classificado no nível **{nivel}**.")
        print("==========================================================")
        
        # O programa vai pausar aqui e esperar o Enter.
        input("\nPressione Enter para voltar ao menu...")

    else:
        try:
            indice_escolhido = int(escolha) - 1
            
            if 0 <= indice_escolhido < len(escola_jujutsu):
                alvo = escola_jujutsu[indice_escolhido]
                nivel_alvo = classificar_feiticeiro(alvo['xp'])
                print("\n----------------------------------------------------------")
                print(f"Análise Individual Concluída:")
                print(f"O Feiticeiro **{alvo['nome']}** está no nível **{nivel_alvo}**.")
                print("----------------------------------------------------------")
                
                # Depois de mostrar o resultado individual, ele também espera.
                input("\nPressione Enter para voltar ao menu...")
            else:
                # Não colocamos a pausa aqui, pois o usuário precisa ver o erro e o menu logo em seguida.
                print("\nOps! Esse número não corresponde a nenhum feiticeiro na lista. Tente de novo.")
        
        except ValueError:
            # E nem aqui. O fluxo de correção de erro deve ser rápido.
            print("\nPor favor, digite apenas o NÚMERO da opção desejada. Energia amaldiçoada textual não funciona aqui!")
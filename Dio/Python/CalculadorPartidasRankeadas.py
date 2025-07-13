# --- Calculadora de Partidas Rankeadas ---

# 1. A FUNÇÃO:
# Ela é como uma caixa preta: recebe vitórias e derrotas, e devolve o saldo e o nível.
def calcular_nivel_ranqueado(vitorias, derrotas):
    """
    Calcula o saldo de vitórias e determina o nível do jogador.
    Parâmetros:
        vitorias (int): A quantidade de vitórias do jogador.
        derrotas (int): A quantidade de derrotas do jogador.
    Retorna:
        tuple: Uma tupla contendo (saldo_de_vitorias, nivel_do_jogador)
    """
    
    # Calculando o saldo de vitórias
    saldo_de_vitorias = vitorias - derrotas
    
    # Variável para armazenar o nível
    nivel_do_jogador = ""
    
    # Estrutura de decisão para determinar o nível com base APENAS nas vitórias
    if vitorias <= 10:
        nivel_do_jogador = "Ferro"
    elif vitorias <= 20:
        nivel_do_jogador = "Bronze"
    elif vitorias <= 50:
        nivel_do_jogador = "Prata"
    elif vitorias <= 80:
        nivel_do_jogador = "Ouro"
    elif vitorias <= 90:
        nivel_do_jogador = "Diamante"
    elif vitorias <= 100:
        nivel_do_jogador = "Lendário"
    else: # Se for maior ou igual a 101
        nivel_do_jogador = "Imortal"
        
    # A função retorna os dois valores que calculamos
    return saldo_de_vitorias, nivel_do_jogador

# 2. O PROGRAMA PRINCIPAL:
vitorias_do_heroi = 95
derrotas_do_heroi = 12

# 3. CHAMANDO A FUNÇÃO E ARMAZENANDO O RESULTADO
saldo_final, nivel_final = calcular_nivel_ranqueado(vitorias_do_heroi, derrotas_do_heroi)


print(f"O Herói tem de saldo de **{saldo_final}** e está no nível de **{nivel_final}**")

# --- Exemplo com outro jogador para mostrar a reutilização ---
saldo_novato, nivel_novato = calcular_nivel_ranqueado(15, 8)
print(f"O Herói novato tem de saldo de **{saldo_novato}** e está no nível de **{nivel_novato}**")
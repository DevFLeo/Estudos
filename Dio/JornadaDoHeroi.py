# 1. Lista de "Jogadores/feiticeiros"
# Criei uma lista de dicionários, onde cada dicionário é um de nós,
# com um nome e um valor de "energia amaldiçoada" (XP).
escola_jujutsu = [
    {"nome": "Maki Zen'in, a Humana Superdotada", "xp": 4500},
    {"nome": "Toge Inumaki, o da Fala Amaldiçoada", "xp": 7100},
    {"nome": "Nobara Kugisaki, a Dama dos Pregos", "xp": 6800}, 
    {"nome": "Megumi Fushiguro, o Mestre das Dez Sombras", "xp": 9200},
    {"nome": "Yuji Itadori, o Receptáculo de Sukuna", "xp": 8800},
    {"nome": "Panda, que não é um Panda", "xp": 5100},
    {"nome": "Satoru Gojo, o Mais Forte (modestamente)", "xp": 10001} # Obviamente...
]

print(" Iniciando a Análise de Nível com os Seis Olhos...")
print("==========================================================")

# 2. O LAÇO DE REPETIÇÃO
# O 'for' vai passar por cada 'feiticeiro' dentro da nossa lista 'escola_jujutsu'.
for feiticeiro in escola_jujutsu:
    
    # Extraindo os dados do feiticeiro atual para variáveis mais simples
    nome_atual = feiticeiro["nome"]
    xp_atual = feiticeiro["xp"]
    nivel_calculado = "" # Resetamos o nível para cada feiticeiro

    # 3. A ESTRUTURA DE DECISÃO: O julgamento.
    # A mesma lógica de antes, afinal, uma técnica dominada não se muda.
    if xp_atual <= 1000:
        nivel_calculado = "Ferro"
    elif xp_atual <= 2000:
        nivel_calculado = "Bronze"
    elif xp_atual <= 5000:
        nivel_calculado = "Prata" 
    elif xp_atual <= 7000:
        nivel_calculado = "Ouro" 
    elif xp_atual <= 8000:
        nivel_calculado = "Platina" 
    elif xp_atual <= 9000:
        nivel_calculado = "Ascendente" 
    elif xp_atual <= 10000:
        nivel_calculado = "Imortal" 
    else: # xp_atual >= 10001
        nivel_calculado = "Radiante" # Um nível criado só para os mais belos e poderosos.

    # 4. A SAÍDA: O veredito para cada um.
    print(f"-> O Feiticeiro **{nome_atual}** foi classificado no nível **{nivel_calculado}**.")

# Mensagem de fim, para fechar com chave de ouro.
print("==========================================================")
print("✅ Análise concluída! O potencial de todos é imenso.")
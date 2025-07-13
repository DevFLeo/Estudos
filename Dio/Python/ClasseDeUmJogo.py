class Heroi:
    # O método construtor __init__ inicializa os atributos do objeto.
    # 'self' representa a instância do objeto que está sendo criado.
    def __init__(self, nome, idade, tipo):
        self.nome = nome
        self.idade = idade
        self.tipo = tipo

    # O método de ataque, que também recebe 'self' para acessar os atributos do objeto.
    def atacar(self):
        # Usando um dicionário para mapear o tipo do herói ao seu ataque.
        # É uma abordagem limpa e muito comum em Python.
        ataques = {
            'mago': 'magia',
            'guerreiro': 'espada',
            'monge': 'artes marciais',
            'ninja': 'shuriken'
        }
        
        # Usamos .get() para pegar o ataque do dicionário.
        # Se o tipo não for encontrado, ele retorna o valor padrão 'um ataque indefinido'.
        ataque = ataques.get(self.tipo, 'um ataque indefinido')
        
        # Usando uma f-string para formatar a mensagem de saída.
        print(f"o {self.tipo} atacou usando {ataque}")


# Instanciando os objetos da classe Heroi (a sintaxe é mais limpa, sem 'new').
# A convenção em Python é usar snake_case para nomes de variáveis.
heroi_mago = Heroi('Merlin', 150, 'mago')
heroi_guerreiro = Heroi('Arthur', 35, 'guerreiro')
heroi_monge = Heroi('Lee', 100, 'monge')
heroi_ninja = Heroi('Hattori', 28, 'ninja')

# Chamando o método atacar para cada herói.
heroi_mago.atacar()
heroi_guerreiro.atacar()
heroi_monge.atacar()
heroi_ninja.atacar()
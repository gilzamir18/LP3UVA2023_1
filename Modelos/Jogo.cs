namespace GameMania.Modelos;

public class Jogo {
    public string Titulo {get; set;}
    public string Genero {get; set;}
    public string Studio {get; set;}
    public string Edicao {get; set;}
    public string Descricao {get; set;}
    public bool Disponibilidade {get;}
    
    private List<string> plataformas;
    private List<Avaliacao> notas;

    public float NotaMedia {
        get {
            if (notas.Count > 0)
                return (float)notas.Average( a => a.Nota );
            else
                return 0;
        }
    }

    public Jogo(string titulo, string genero, string studio, string edicao, bool disponilidade = true) {
        this.Titulo = titulo;
        this.Genero = genero;
        this.Studio = studio;
        this.Edicao = edicao;
        this.Disponibilidade = disponilidade;
        plataformas = new();
        notas = new();
    }

    public void ExibirFichaTecnica() {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Studio: {Studio}");
        Console.WriteLine($"Edição: {Edicao}");
        Console.WriteLine($"Descrição: {Descricao}");
        Console.Write("Plataformas Suportadas:\t");
        foreach(var plat in plataformas) {
            Console.Write($"{plat} ");
        }
        Console.WriteLine();
        
        if (Disponibilidade)
            Console.WriteLine("Jogo disponível para avaliação.");
        else
            Console.WriteLine("Este jogo não está disponível para avaliação.");

        Console.WriteLine();
    }

    public void AdicionarNota(Avaliacao nota) {
        notas.Add(nota);
    }

    public void AdicionarPlataforma(string plataforma) {
        plataformas.Add(plataforma);
    }
}
namespace DesignPatterns.DesignPatterns.Creational.Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pessoa professor = new Professor("Jubileu", "Matematica");
            Pessoa professor2 = new Professor("Maria", "Portugues");
            Pessoa professor3 = professor.Clone();

            IList<Pessoa> pessoas = new List<Pessoa>() { professor, professor2, professor3 };

            pessoas.ToList().ForEach(p => p.Apresentar());
        }
    }


    public abstract class Pessoa
    {

        public string Nome { get; set; }

        public Pessoa() { }

        public Pessoa(Pessoa pessoa)
        {
            Nome = pessoa.Nome;
        }

        public abstract Pessoa Clone();

        public abstract void Apresentar();
    }

    public class Professor : Pessoa
    {
        public string Materia { get; set; }

        public Professor(string nome, string materia)
        {
            Nome = nome;
            Materia = materia;
        }

        public Professor(Professor professor) : base(professor)
        {
            Materia = professor.Materia;
        }

        public override Pessoa Clone()
        {
            return new Professor(this);
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, sou {this.Nome} e leciono {this.Materia}. Meu código de registro é {this.GetHashCode()}");
        }
    }




}

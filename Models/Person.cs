namespace aula_11_programacao_orientada_objetos.Models
{
    public class Person
    {
        public int id {get; set;}

        public string name {get; set;}

        public string address {get; set;}

        public Person(int id, string name, string address) {
            this.id = id;
            this.name = name;
            this.address = address;
        }
    }
}
namespace ExercicioFVetores
{
    internal class Rooms
    {
        public string _nome;
        public string Email { get; set;}
        public int Room { get; set;}

        public Rooms(string nome, string email, int room)
        {
            _nome = nome;
            Email = email;
            Room = room;
        }

        public string Nome
        {
            get { return _nome; }
            set { if(value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
    }
}

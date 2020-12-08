/*cadastrousuario*/
public int IDCadastroUsuario { get; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }

Nome,Email,Senha,DataNascimento,Sexo


/*agena*/
public int IDAgenda { get; set; }
        public string EventosEmAndamentos { get; set; }
        public string ProximosEventos { get; set; }
        public int ID_Evento { get; set; }
        public int ID_Login { get; set; }




/*evento*/
public int IDEvento { get;}
        public string  Tipo 
        public string  Nome 
        public string  Descriçao 
        public         DateTime Data 
        public string  Local 
        public string  Participantes 




/*login*/
 public int IDLogin { get; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int ID_CadastroUsuario { get;}
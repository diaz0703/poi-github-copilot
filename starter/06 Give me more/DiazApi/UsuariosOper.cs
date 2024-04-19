using System.Collections.Generic;

public class Usuarios
{
    List<Usuario> usuarios;

    public Usuarios()
    {
            usuarios = new List<Usuario>();
            usuarios.Add(new Usuario(){ Id = 1, Nombre = "Usuario 1", Edad = 20, Departamento = "Departamento 1", Signo = "Signo 1" });
            usuarios.Add(new Usuario(){ Id = 2, Nombre = "Usuario 2", Edad = 21, Departamento = "Departamento 2", Signo = "Signo 2" }); 
            usuarios.Add(new Usuario(){ Id = 3, Nombre = "Usuario 3", Edad = 22, Departamento = "Departamento 3", Signo = "Signo 3" });     
            usuarios.Add(new Usuario(){ Id = 4, Nombre = "Usuario 4", Edad = 23, Departamento = "Departamento 4", Signo = "Signo 4" }); 
            usuarios.Add(new Usuario(){ Id = 5, Nombre = "Usuario 5", Edad = 24, Departamento = "Departamento 5", Signo = "Signo    5" });  
    }
    public List<Usuario> GetUsuarios()
    {
        // Add your logic here to retrieve the list of users

        return usuarios;
    }

//crea una funcion que reciba un id y devuelva el usuario con ese id
    public Usuario GetUsuario(int id)
    {
        // Add your logic here to retrieve the user with the given id
        return usuarios.Find(x => x.Id == id);
    }



}


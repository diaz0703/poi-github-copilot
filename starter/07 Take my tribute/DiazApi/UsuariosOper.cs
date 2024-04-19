using System.Collections.Generic;

public class Usuarios
{
    List<Usuario> usuarios;

    public Usuarios()
    {
            usuarios = new List<Usuario>();
            usuarios.Add(new Usuario(){ Id = 47, Nombre = "Usuario 1", Edad = 20, Departamento = "Departamento 1", Signo = "Signo 1" });
            usuarios.Add(new Usuario(){ Id = 20, Nombre = "Usuario 2", Edad = 21, Departamento = "Departamento 2", Signo = "Signo 2" }); 
            usuarios.Add(new Usuario(){ Id = 35, Nombre = "Usuario 3", Edad = 22, Departamento = "Departamento 3", Signo = "Signo 3" });     
            usuarios.Add(new Usuario(){ Id = 41, Nombre = "Usuario 4", Edad = 23, Departamento = "Departamento 4", Signo = "Signo 4" }); 
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


    //crea una funcion que reciba un usuario lo inserte en la lista, le asigne el siguiente id y devuelva el usuario insertado
    public ResultadoUsuarios InsertarUsuario(Usuario usuario)
    {
        // Add your logic here to insert the user in the list
        usuario.Id = usuarios.Max(x => x.Id) + 1;
        usuarios.Add(usuario);
        ResultadoUsuarios resultado = new ResultadoUsuarios();
        resultado.NuevoId = usuario.Id;
        resultado.NumeroUsuarios = usuarios.Count;
        return resultado;
    }

    //crea una funcion que reciba un usuario lo actualice en la lista y devuelva el usuario actualizado
    public Usuario UpdateUsuario(Usuario usuario)
    {
        // Add your logic here to update the user in the list
        var user = usuarios.Find(x => x.Id == usuario.Id);
        user.Nombre = usuario.Nombre;
        user.Edad = usuario.Edad;
        user.Departamento = usuario.Departamento;
        user.Signo = usuario.Signo;
        return user;
    }

    //crea una funcion que reciba un id y elimine el usuario con ese id de la lista
    public void DeleteUsuario(int id)
    {
        // Add your logic here to delete the user with the given id
        var user = usuarios.Find(x => x.Id == id);
        usuarios.Remove(user);
    }



}


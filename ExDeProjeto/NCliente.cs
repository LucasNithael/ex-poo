using System;
using System.Collections.Generic;

class NCliente{
  public List<Cliente> clientes = new List<Cliente>();
  public static int Inserir(Cliente c){
    int id = 0;
    foreach(Cliente obj in clientes)
      if(obj.Id > id) id = obj.Id;
    id++;
    u.Id = id;
    clientes.Add(u);
    return id;
  }
  public Cliente Listar(int IdUsuario){
    foreach(Cliente i in clientes)
      if(IdUsuario == i.IdUsuario)
        return i;
    return null;
  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CAInventario
{
    public class Producto
    {
        //Declaración de las propiedades de la clase Producto
        private int IDProducto, Existencia, IDCategoria;
        private string Nombre;
        private double Precio;
        private bool Activo = true;
        //Constructor vacío de la clase
        public Producto()
        {
        } //fin del constructor vacio
          //Constructor con paratametros que permitirá crear instancias pasándole los valores que tendrán las
        public Producto(int idproducto, int idcategoria, int existencia, String nombre, double precio, bool activo)
        {
            this.IDProducto = idproducto; //Asigna a la propiedad IDProducto el valor del parámetro idproducto
            this.IDCategoria = idcategoria; //Asigna a la propiedad IDCategoria el valor del parámetro idcategoria
            this.Nombre = nombre; //Asigna a la propiedad Nombre el valor del parámetro nombre
            this.Precio = precio; //Asigna a la propiedad Precio el valor del parámetro precio
            this.Existencia = existencia; //Asigna a la propiedad Existenca el valor del parámetro existencia
            this.Activo = activo; //Asigna a la propiedad Activo el valor del parámetro activo
        } //fin del constructor que acepta 6 parámetros
          //METODOS DE ACCESO
          //Devuelve el valor de la propiedad IDProducto de la clase Producto
        public int getIDProducto()
        {
            return IDProducto;
        } //fin del metodo getIDProducto

        //Devuelve el valor de la propiedad IDCategoria de la clase Producto
        public int getIDCategoria()
        {
            return IDCategoria;
        } //fin del metodo getIDCategoria
          //Devuelve el valor de la propiedad Nombre de la clase Producto
        public String getNombre()
        {
            return Nombre;
        } //fin del metodo getNombre
          //Devuelve el valor de la propiedad Precio de la clase Producto
        public double getPrecio()
        {
            return Precio;
        } //fin del metodo getPrecio
          //Devuelve el valor de la propiedad Existencia de la clase Producto
        public int getExistencia()
        {
            return Existencia;
        } //fin del metodo getExistencia
          //Devuelve el valor de la propiedad Existencia de la clase Producto
        public bool getActivo()
        {
            return Activo;
        } //fin del metodo getExistencia
          //METODOS DE MODIFICACION
          //Asigna el valor pasado como parámetro a la propiedad correspondiente de la clase Producto
        public void setIDProducto(int idproducto)
        {
            this.IDProducto = idproducto;
        } //fin del metodo setIDProducto
          //Asigna el valor pasado como parámetro a la propiedad correspondiente de la clase Producto
        public void setIDCategoria(int idcategoria)
        {
            this.IDCategoria = idcategoria;
        } //fin del metodo setIDCategoria
          //Asigna el valor pasado como parámetro a la propiedad correspondiente de la clase Producto



        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        } //fin del metodo setNombre
          //Asigna el valor pasado como parámetro a la propiedad correspondiente de la clase Producto
        public void setPrecio(double precio)
        {
            this.Precio = precio;
        } //fin del metodo setPrecio
          //Asigna el valor pasado como parámetro a la propiedad correspondiente de la clase Producto
        public void setExistencia(int existencia)
        {
            this.Existencia = existencia;
        } //fin del metodo setExistencia
        public void setActivo(bool activo)
        {
            this.Activo = activo;
        } //fin del metodo setExistencia
          //OTROS METODOS
          //Método para aumentar la cantidad en existencia de un producto
        public void AgregarAInventario(int cantidad)
        {
            if (this.Activo)
                this.Existencia += cantidad; //le agrega la cantidad de unidades a la existencia del producto
            else
                Console.WriteLine("\n* * * No se puede agregar stock a una línea descontinuada * * * ");
        } //fin del método AgregarAInventario
          //Método para reducir la cantidad en existencia de un producto
        public void ReducirInventario(int cantidad)
        {
            if (this.Activo)
                this.Existencia -= cantidad; //reduce la cantidad indicada a la existencia del producto
            else
                Console.WriteLine("\n* * * No se puede reducir stock a una línea descontinuada * * * ");
        } //fin del método ReducirInventario
    } //fin de la clase Producto
}
# Tarea 2

================

### Declaración de clases atributos métodos encapsulamiento

Las clases y estructuras encapsulan conjuntos de datos y forman comportamientos, en ella , vienen incluidas las propiedades, los metodos, etc.
Cuando por ejemplo se declara una variable de tipo de la clase, significa que es un objeto. Se pueden usar varias veces la clase para crear objetos, al momento de crear objetos se crean referencias a esa memoria, cuando una referencia de objeto se le asigna una variable nueva, la nueva variable crea una nueva referencia.
Las estructuras son tipos de valores, cuando se crea una variable a la que se asigna la estructura, lleva consigo los datos, cuando la estructura se asigna a nueva variable, se copia, asi que las dos variables contienen dos copias individuales de los mismos datos, pero no se afectan si hacen cambios.

====================

## Instanciación de una clase

El operador new (Referencia en C#), se usa para crear objetos e invocar constructores, por ejemplo:
Class1 obj = new Class1();

Tambien se usa para crear instancias de tipos anónimos:
var query = from cust in customers
            select new { Name = cust.Name, Address = cust.PrimaryAddress };

El operador new tambien se usa para invocar el constructor predeterminado para tipos de valor. Por ejemplo:
int i = new int();

===================

## Escribe un programa donde utilices this para obtener acceso a miembros con el fin de evitar ambigüedades con nombres similares

class ClaseName
{
    public string ejemplo;
    {
    public ClaseName(string ejemplo)
        {
            this.ejemplo = ejemplo;
        }
    }
}

===================

## Métodos: declaración, mensajes, paso de parámetros, retorno de valores

Existen palabras claves para los metodos llamados valores, estos son:
params: Este parametro puede tomar un numero variable de argumentos.
in: Dice que este parametro pasa por referencia, pero solo se lee mediante el metodo llamado.
ref: Habla de que este parametro se pasa por referencia y puede ser leido o escrito por el metodo llamado.
out: Especifica que este parametro se pasa por referencia y se escribe mediante el metodo llamado.

===================

## Constructores y destructores: declaración, uso y aplicaciones

Los constructores son metodos que se realizan cuando se crea un objeto cualquiera, tienen el mismo nombre que la clase e inicializan los datos del objeto creado.
Cuando un costructor no agarra ningun parametro se conoce como predeterminado, y estos se invocan cada vez que se crea una instancia de un objeto con el "new", y no se proporciona ningun argumento a new.
Los costructores para tipo struct no pueden tener costructor predeterminado porque el compilador proporciona uno automatico, ejemplo:

int i = new int();
Console.WriteLine(i);

Cualquiero constructor puede usar la palabra clave base para llamar al costructor de una clase base.
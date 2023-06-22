using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList productos = new ArrayList();
        bool isAddProducto = true;
        int opc=0;
        while (isAddProducto){
            Console.Clear();
            Console.Write("1.Agregar producto\n2.Buscar producto\n3.Listar productos\n4.Salir");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc){
                case 1:
                    Console.WriteLine("Nombre producto:");
                    string nombreProducto = Console.ReadLine() ?? String.Empty;
                    Console.WriteLine("Precio producto:");
                    double precioProducto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Cantidad productos:");
                    int cantidadProducto = Convert.ToInt32(Console.ReadLine() ?? String.Empty);
                    productos.Add(nombreProducto.ToUpper()+","+precioProducto.ToString()+","+cantidadProducto.ToString());
                    break;
                case 2:
                    Console.Write("Ingrese el nombre del producto a buscar:");
                    string ? palabra = (Console.ReadLine() ?? String.Empty).ToUpper();
                    foreach(String item  in productos){
                        if(item.ToString().Contains(palabra)){
                            string[] product = item.Split(",");
                                Console.WriteLine($"Nombre : {product[0]}");
                                Console.WriteLine($"Precio : {Convert.ToDecimal(product[1]).ToString("C2")}");
                                Console.WriteLine($"Cantidad : {Convert.ToInt32(product[2])}");
                                Console.ReadKey();
                                break;
                        }
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("{0,-15} {1,15} {2,25}","Nombre Producto","Cantidad","Precio Unitario");
                    foreach(String item  in productos){
                        string[] product = item.Split(",");
                        string pro = product[0].Substring(0,10);
                        Console.WriteLine("{0,-15} {1,8} {2,25:C2}",pro,product[2],Convert.ToDecimal( product[1]));                        
                    }
                    Console.ReadKey();
                    break;
                case 4:
                    isAddProducto=false;
                    break;
                default:
                    Console.Clear();
                    Console.Write("Opcion no valida en el menu");
                    break;
            }
        }
    }
}
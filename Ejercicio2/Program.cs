Console.WriteLine("\n\r============================================");
Console.WriteLine("\n\r        Sistema de cajero Automatico        ");
Console.WriteLine("\n\r============================================");
lectura();

static void lectura()
{
    Cuentas accs = new Cuentas();
    Console.Write("\nPor favor, ingrese su NIP: ");

    int NIP;
    bool flag = Int32.TryParse(Console.ReadLine(), out NIP);

    if (flag && NIP > 0)
    {
        Console.WriteLine("\n\rSe ha ingresado un NIP valido");
        for(int i = 0; i < accs.NIP.Length; i++)
        {
            if (NIP == accs.NIP[i])
            {
                Console.WriteLine("\n\rHola de nuevo, " + accs.Nombre[i]);
                menu(NIP);
            }
            else
                continue;
        }
    }
    else
    {
        Console.WriteLine("Por favor, ingrese un NIP valido");
        lectura();
    }
}

static void menu(int NIP)
{
    int actual_acc = NIP;
    int opc;

    Console.WriteLine("\n\r============================================");
    Console.Write("\n\rSeleccione la solicitud que desea realizar\n\r");
    Console.WriteLine("\n\r============================================");

    Console.WriteLine("\n\r1.- Consulta de saldo");
    Console.WriteLine("\n\r2.- Retirar efectivo");
    Console.WriteLine("\n\r3.- Consultar movimientos");
    Console.WriteLine("\n\r4.- Salir");
    Console.WriteLine("\n\r============================================");

    Console.Write("Opcion solicitada: ");

    bool flag = Int32.TryParse(Console.ReadLine(), out opc);
    if(flag && opc >= 0)
    {
        switch (opc)
        {
            case 1:
                Console.WriteLine("Usted selecciono, consulta de saldo");
                Thread.Sleep(1000);
                Console.Clear();
                menu(NIP);
                break;
            case 2:
                Console.WriteLine("Usted selecciono, retiro de efectivo");
                Thread.Sleep(1000);
                menu(NIP);
                break;
            case 3:
                Console.WriteLine("Usted selecciono, consulta de movimientos");
                Thread.Sleep(1000);
                menu(NIP);
                break;
            default:
                Console.WriteLine("Saliendo del sistema...");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("\n\r============================================");
                Console.WriteLine("\n\r        Sistema de cajero Automatico        ");
                Console.WriteLine("\n\r============================================");
                lectura();
                break;
        }
    }
}

public class Cuentas
{
    public int[] NIP = {3867, 3868, 3869};
    public string[] Nombre = {"Andres Rosales", "Norandry Labarca", "Chanchita Feliz"};
    public int[] Saldo = { 4000, 4000, 4000 };
}
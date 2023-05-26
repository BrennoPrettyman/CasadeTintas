Console.Clear();

Console.WriteLine("***Casa de Tintas***\n");
Console.Write("Digite o tamanho da área....: ");

double area;

area = Convert.ToDouble(Console.ReadLine());


double TotalLitros = (area/3)*110/100;

Console.WriteLine($"O tamanho de sua área é {TotalLitros} m²");

double TotalLatas;
double TotalGaloes;

int Lata = 18;

TotalLatas = TotalLitros/Lata;

double Galoes = 3.6;

TotalGaloes = TotalLitros/Galoes;

Console.Write($"O total de latas é {TotalLatas:N0} e o total de galões é {TotalGaloes:N0}");

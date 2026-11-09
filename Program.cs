Console.Write("masukan nama pelanggan: ");
string namaPelanggan = Console.ReadLine();

Console.Write("Masukan jumlah halaman: ");
int jumlahHalaman = int.Parse(Console.ReadLine());

Console.Write("Masukan harga per halaman:");
int hargaPerHalaman = int.Parse(Console.ReadLine());

const int biayaAdministrasi = 2000;

int subtotal = jumlahHalaman + hargaPerHalaman;
int totalBayar = subtotal * biayaAdministrasi;

Console.WriteLine();
Console.WriteLine("=== RINNCIAN PENCETAKAN ===");
Console.WriteLine($"Nama pelanggan = {namaPelanggan}");
Console.WriteLine($"Jumlah halaman = {jumlahHalaman}");
Console.WriteLine($"Hargar per halaman = {hargaPerHalaman}");
Console.WriteLine($"Subtotal = {hargaPerHalaman}");
Console.WriteLine($"Biaya administrasi = {biayaAdministrasi}");
Console.WriteLine($"Total bayar = {totalBayar}");
using System;

namespace c__konversi_mata_uang
{
    class Program
    {
        static void Main(string[] args)
        {

									double nilaiValuasi, nilaiInput, hasilKe, hasilDari;
									int pilihanMataUang, pilihanKonversi;

									awal:
									Console.WriteLine("APLIKASI KONVERSI MATA UANG");
									Console.WriteLine("============================");
									Console.WriteLine("1. USD");
									Console.WriteLine("2. EUR");
									Console.WriteLine("3. JPY");

									Console.WriteLine();
									Console.Write("Masukkan Angka Pilihan Anda: ");

									bool pilihanMataUangIsNumeric = int.TryParse(Console.ReadLine(), out pilihanMataUang);
									Console.Clear();

									if(pilihanMataUangIsNumeric){
										switch (pilihanMataUang)
										{
												case 1:

												Console.WriteLine("Daftar Pilihan");
												Console.WriteLine("1. USD to IDR");
												Console.WriteLine("2. IDR to USD");

												Console.WriteLine("===================");

												Console.Write("Masukkan Pilihan Anda: ");
												bool isNumericUSD = int.TryParse(Console.ReadLine(), out pilihanKonversi);

												if(isNumericUSD){
													switch (pilihanKonversi)
														{
															case 1:
																Console.Clear();
																Console.WriteLine("USD to IDR");
																Console.WriteLine("====================");

																nilaiValuasi = 14000;

																Console.Write("Masukkan Jumlah Dollar Anda : ");
																nilaiInput = Convert.ToInt32(Console.ReadLine());

																hasilDari = nilaiValuasi * nilaiInput;

																Console.WriteLine("Jadi Total Anda : Rp " + hasilDari);

																break;
															case 2:
																Console.Clear();
																Console.WriteLine("IDR to USD");
																Console.WriteLine("==============");

																nilaiValuasi = 14000;

																Console.Write("Masukkan jumlah Rupiah : ");
																nilaiInput = Convert.ToDouble(Console.ReadLine());

																hasilKe = nilaiInput / nilaiValuasi;

																Console.WriteLine(" Jadi Total anda : $ " + hasilKe);

																break;
															default:
																Console.WriteLine("Tidak Ada dalam Daftar");
																break;
														}
												} else {
													Console.Clear();
													Console.WriteLine("Masukkan Hanya Angka !");
													goto pilihanLanjutAtauTidak;
												}

												break;

												case 2:

												Console.WriteLine("Daftar Pilihan");
												Console.WriteLine("1. EUR to IDR");
												Console.WriteLine("2. IDR to EUR");

												Console.WriteLine("===================");

												Console.Write("Masukkan Pilihan Anda: ");
												bool isNumericEUR = int.TryParse(Console.ReadLine(), out pilihanKonversi);

												if(isNumericEUR){
													switch (pilihanKonversi)
														{
															case 1:
																Console.Clear();
																Console.WriteLine("EUR to IDR");
																Console.WriteLine("====================");

																nilaiValuasi = 16000;

																Console.Write("Masukkan Jumlah EURO Anda : ");
																nilaiInput = Convert.ToInt32(Console.ReadLine());

																hasilDari = nilaiValuasi * nilaiInput;

																Console.WriteLine("Jadi Total Anda : Rp " + hasilDari);

																break;
															case 2:
																Console.Clear();
																Console.WriteLine("IDR to EUR");
																Console.WriteLine("==============");

																nilaiValuasi = 16000;

																Console.Write("Masukkan jumlah Rupiah : ");
																nilaiInput = Convert.ToDouble(Console.ReadLine());

																hasilKe = nilaiInput / nilaiValuasi;

																Console.WriteLine(" Jadi Total anda : EUR " + hasilKe);

																break;
															default:
																Console.WriteLine("Tidak Ada dalam Daftar");
																break;
														}
												} else {
													Console.Clear();
													Console.WriteLine("Masukkan Hanya Angka !");
													goto pilihanLanjutAtauTidak;
												}

												break;

												case 3:

												Console.WriteLine("Daftar Pilihan");
												Console.WriteLine("1. JPY to IDR");
												Console.WriteLine("2. IDR to JPY");

												Console.WriteLine("===================");

												Console.Write("Masukkan Pilihan Anda: ");
												bool isNumericJPY = int.TryParse(Console.ReadLine(), out pilihanKonversi);

												if(isNumericJPY){
													switch (pilihanKonversi)
														{
															case 1:
																Console.Clear();
																Console.WriteLine("JPY to IDR");
																Console.WriteLine("====================");

																nilaiValuasi = 127;

																Console.Write("Masukkan Jumlah Yen Anda : ");
																nilaiInput = Convert.ToInt32(Console.ReadLine());

																hasilDari = nilaiValuasi * nilaiInput;

																Console.WriteLine("Jadi Total Anda : Rp " + hasilDari);

																break;
															case 2:
																Console.Clear();
																Console.WriteLine("IDR to JPY");
																Console.WriteLine("==============");

																nilaiValuasi = 127;

																Console.Write("Masukkan jumlah Rupiah : ");
																nilaiInput = Convert.ToDouble(Console.ReadLine());

																hasilKe = nilaiInput / nilaiValuasi;

																Console.WriteLine(" Jadi Total anda : JPY " + hasilKe);

																break;
															default:
																Console.WriteLine("Tidak Ada dalam Daftar");
																break;
														}
												} else {
													Console.Clear();
													Console.WriteLine("Masukkan Hanya Angka !");
													goto pilihanLanjutAtauTidak;
												}

												break;

												default:
													Console.Clear();
													Console.WriteLine("Masukkan Hanya Angka Saja !");
													goto pilihanLanjutAtauTidak;
												break;
										}
									}else{
										Console.WriteLine("Masukkan Hanya Angka !");
										goto pilihanLanjutAtauTidak;
									}

									pilihanLanjutAtauTidak:
										Console.WriteLine("Lanjut ? [yes/no] : ");
										string pilihanLanjut = Console.ReadLine();

										if(pilihanLanjut.ToLower() == "yes"){
											Console.Clear();
											goto awal;
										} else if(pilihanLanjut.ToLower() == "no") {
											Console.Clear();
											Console.WriteLine("Sampai Jumpa");
										} else {
											Console.WriteLine("Tidak Ada dalam daftar");
											Console.WriteLine();
											goto pilihanLanjutAtauTidak;
										}					



        }
    }
}

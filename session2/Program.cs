// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;

Console.WriteLine("Hello, World!");

// phím tắt tạo command (ghi chú) nhiều dòng: ctrl + ?. Bấm lại là bỏ cmd

#region Học phép toán cơ bản
// // học +, -, *, / (chia lấy phần nguyên), % (chia lấy phần dư)
// // khai báo biến
// int add = 5 + 10;
// Console.WriteLine($"Kết quả cộng hai số 5 và 10 là: {add}");

// int minus = 92421 - 8327;
// Console.WriteLine($"Kết quả trừ 2 số là: {minus}");

// double devide = 5/2;
// Console.WriteLine($"Kết quả chia 2 số là: {devide}");

#endregion

#region numberic toán tử
// int cong = 0; // định nghĩa biến cong có giá trị mặt định = 0
// cong += 10;
// Console.WriteLine($"kết quả numberic toán tử cộng là: {cong}");

// int tru = 100;
// tru -= 49;
// Console.WriteLine($"Kết quả numberic toán tử cộng là: {tru}");

// int nhan = 2;
// nhan *= 11;
// Console.WriteLine($"Kết quả numberic toán tử cộng là: {nhan}");

#endregion

#region ép kiểu dữ liệu C1: dùng convert
// Convert
// // nhập dữ liệu từ bàn phím => Readline (string)
// Console.WriteLine("Mời bạn nhập số: ");
// string number = Console.ReadLine();
// int convertNumber = Convert.ToInt32 (number);
// // int sum = convertNumber + 1;
// // Console.WriteLine($"gia tri: {sum}");
// Console.WriteLine($"value number: {convertNumber}");

#endregion

#region tính chỉ số BMI
// // Input
// // Chiều cao và cân nặng nhập từ bàn phím
// Console.WriteLine("Mời bạn nhập chiều cao (m):");
// string chieucao = Console.ReadLine();
// // convert string sang double
// double formatchieucao = Convert.ToDouble(chieucao);

// Console.WriteLine("Mời bạn nhập cân nặng (kg): ");
// string cannang = Console.ReadLine();
// double formatcannang = Convert.ToDouble(cannang);

// // Output
// // In ra chỉ số BMI
// // Khởi tạo biến bmi để lưu giá trị BMI
// double bmi = 0.0;

// // Process
// // BMI = Cân nặng / chiều cao * chiều cao
// bmi = formatcannang / (formatchieucao*formatchieucao);
// Console.WriteLine($"Chỉ số BMI của bạn là: {bmi}");


#endregion

#region tính chu vi và diện tích hình tròn
// // Input
// // B1: nhập bán kính từ bàn phím
// Console.WriteLine($"Mời bạn nhập bán kính hình tròn: ");
// string bankinh = Console.ReadLine();
// // B2: convert kiểu dữ liệu string -> double cho bán kính
// double formatbankinh = Convert.ToDouble(bankinh);

// // Output
// double chuvi = 0.0;
// double dientich = 0.0;

// // Process
// double PI = Math.PI; // dùng hằng số PI có sẵn của thư viện Math trong C#
// // Chu vi = 2 * pi * bankinh
// chuvi = 2 * PI * formatbankinh;
// // Diện tích = pi * bankinh * bankinh
// dientich = PI * formatbankinh * formatbankinh;

// Console.WriteLine($"Chu vi hình tròn là: {chuvi}");
// Console.WriteLine($"Diện tích hình tròn là: {dientich}");

#endregion


#region Bài tập 1 - Buổi 2 - Tính số ngày trong tuần và số ngày lẻ
// // Input
// // Nhập số ngày cần tính từ bàn phím
// Console.WriteLine($"Nhập số ngày cần tính: ");
// string songay = Console.ReadLine();
// int formatsongay = Convert.ToInt32(songay);

// // Output
// int sotuan = 0;
// int songayle = 0;

// // Process
// // Tính ra bao nhiêu tuần và bao nhiêu ngày lẻ
// // Tính số tuần
// sotuan = formatsongay / 7;
// Console.WriteLine($"Số tuần tính toán là: {sotuan} tuần");
// // Tính số ngày lẻ
// songayle = formatsongay % 7;
// Console.WriteLine($"Số ngày lẻ tính toán là: {songayle} ngày");
#endregion 

#region Bài tập 2 - Buổi 2 - Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá
// // Input
// // Nhập giá trị đơn hàng và % giảm giá
// Console.WriteLine("Nhập giá trị đơn hàng:");
// string donhang = Console.ReadLine();
// double fdonhang = Convert.ToDouble(donhang);
// Console.WriteLine("Nhập % giảm giá:");
// string giamgia = Console.ReadLine();
// double fgiamgia = Convert.ToDouble(giamgia);

// // Output
// double tonggiamgia = 0.0;
// double tongtien = 0.0;

// // Process
// // Tính số tiền giảm giá
// tonggiamgia = fdonhang * fgiamgia / 100;
// Console.WriteLine($"Số tiền giảm giá là: {tonggiamgia}");
// // Tính tổng số tiền sau khi giảm giá
// tongtien = fdonhang - tonggiamgia;
// Console.WriteLine($"Tổng số tiền sau khi giảm giá là: {tongtien}");

#endregion

#region Bài tập 3 - Buổi 2 - Chuyển đổi thời gian từ phút sang giờ và phút
// // Input
// // Nhập giá trị thời gian theo phút
// Console.WriteLine("Nhập giá trị thời gian theo phút:");
// string phut = Console.ReadLine();
// int fphut = Convert.ToInt32(phut);

// // Output
// int sogio = 0;
// int sophut = 0;

// // Process
// // Tính số giờ
// sogio = fphut / 60;
// // Tính số phút
// sophut = fphut % 60;
// Console.WriteLine($"Số giờ sau tính toán là: {sogio} giờ và {sophut} phút");

#endregion

#region Bài tập 4 - Buổi 2 - Tính tổng tiền sau khi cộng thêm thuế VAT
// // Input
// // Nhập số tiền gốc
// Console.WriteLine("Nhập số tiền gốc:");
// string tiengoc = Console.ReadLine();
// double ftiengoc = Convert.ToDouble(tiengoc);
// // Nhập tỉ lệ thuế VAT
// Console.WriteLine("Nhập % thuế VAT:");
// string vat = Console.ReadLine();
// double fvat = Convert.ToDouble(vat);

// // Output
// double tongVAT = 0.0;
// double tongtiensauVAT = 0.0;

// // Process
// // Tính số tiền chịu thuế VAT
// tongVAT = ftiengoc * fvat / 100;
// // Tính tổng số tiền sau khi cộng thêm VAT
// tongtiensauVAT = ftiengoc + tongVAT;
// Console.WriteLine($"Tổng số tiền sau khi cộng thêm thuế VAT là: {tongtiensauVAT}");

#endregion

#region Bài tập 5 - Buổi 2 - Chuyển đổi đơn vị tiền tệ từ USD sang VND
// // Input
// // Nhập số tiền USD
// Console.WriteLine("Nhập số tiền bằng USD:");
// string tienusd = Console.ReadLine();
// Int64 ftienusd = Convert.ToInt64(tienusd);
// // Nhập tỉ giá USD-VND
// Console.WriteLine("Nhập tỉ giá USD-VND:");
// string tigia = Console.ReadLine();
// Int64 ftigia = Convert.ToInt64(tigia);

// // Output
// Int64 tiensauchuyendoi = 0;

// // Process
// // Tính tổng số tiền sau khi nhân tỉ giá
// tiensauchuyendoi = ftienusd * ftigia;
// Console.WriteLine($"Tổng số tiền sau khi nhân tỉ giá là: {tiensauchuyendoi}");

#endregion


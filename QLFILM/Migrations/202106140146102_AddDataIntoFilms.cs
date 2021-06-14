namespace QLFILM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataIntoFilms : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F001', N'The Scent of Green Papaya', N'Mùi Đu Đủ Xanh', 1993, 104, 7.4000000953674316, 1.91);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F002', N'Cyclo', N'Xích Lô', 1995, 123, 7.3000001907348633, 0.08);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F003', N'The Vertical Ray of the Sun', N'Mùa Hè Chiều Thẳng Đứng', 2000, 112, 7.1999998092651367, 0.46);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F004', N'Furie', N'Hai Phượng', 2019, 98, 6.3000001907348633, 0.59);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F005', N'Ba mùa', N'Ba Mùa', 1999, 104, 7.1999998092651367, 2.02);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F006', N'The Rebel', N'Dòng Máu Anh Hùng', 2007, 103, 7, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F007', N'The Third Wife', N'Vợ Ba', 2018, 96, 6.6999998092651367, 0.08);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F008', N'Yellow Flowers on the Green Grass', N'Tôi Thấy Hoa Vàng Trên Cỏ Xanh', 2015, 103, 7.5999999046325684, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F009', N'Clash', N'Bẫy Rồng', 2009, 90, 6, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F010', N'Cú và Chim Se Sẻ', N'Cú Và Chim Se Sẻ', 2007, 97, 7.3000001907348633, 0.05);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F011', N'Journey from the Fall', N'Vượt Sóng', 2006, 135, 7.0999999046325684, 0.64);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F012', N'Sword of the Assassin', N'Thiên Mệnh Anh Hùng', 2012, 103, 6.3000001907348633, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F013', N'Hot Boy Nổi Loạn và Câu Chuyện Về Thằng Cười, Cô Gái Điếm và Con Vịt', N' Hot Boy Nổi Loạn và Câu Chuyện Về Thằng Cười, Cô Gái Điếm và Con Vịt', 2011, 103, 6.8000001907348633, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F014', N'Mùa len trâu', N'Mùa Len Trâu', 2004, 102, 6.9000000953674316, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F015', N'Áo Lụa Hà Đông', N'Áo Lụa Hà Đông', 2006, 142, 7.4000000953674316, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F016', N'Jailbait', N'Em Chưa 18', 2017, 95, 6.5, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F017', N'Bụi Đời Chợ Lớn', N'Bụi Đời Chợ Lớn', 2013, 85, 6.8000001907348633, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F018', N'Để Mai Tính', N'Để Mai Tính', 2010, 95, 6.5999999046325684, 0.17);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F019', N'Em Là Bà Nội Của Anh', N'Em Là Bà Nội Của Anh', 2015, 127, 7.0999999046325684, 0.07);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F020', N'Bi, Đừng Sợ!', N'Bi, Đừng Sợ!', 2010, 91, 6.6999998092651367, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F021', N'Quả Tim Máu', N'Quả Tim Máu', 2014, 97, 7.0999999046325684, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F022', N'Cha và con và...', N'Cha Và Con Và …', 2015, 102, 6.3000001907348633, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F023', N'Cô Ba Sài Gòn', N'Cô Ba Sài Gòn', 2017, 100, 6.6999998092651367, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F024', N'When the Tenth Month Comes', N'Bao Giờ Cho Đến Tháng Mười', 1984, 95, 7.6999998092651367, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F025', N'Mắt Biếc', N'Mắt Biếc', 2019, 117, 7.0999999046325684, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F026', N'Song lang', N'Song Lang', 2018, 90, 7.8000001907348633, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F027', N'Cánh Đồng Bất Tận', N'Cánh Đồng Bất Tận', 2010, 105, 7.0999999046325684, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F028', N'Tháng Năm Rực Rỡ', N'Tháng Năm Rực Rỡ', 2018, 118, 7.3000001907348633, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F029', N'Adrift', N'Chơi Vơi', 2009, 110, 6.4000000953674316, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F030', N'Tèo em', N'Tèo Em', 2013, 99, 6.6999998092651367, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F031', N'Cô Dâu Đại Chiến', N'Cô Dâu Đại Chiến', 2011, 100, 6, 0.06);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F032', N'Co gai den tu hom qua', N'Cô Gái Đến Từ Hôm Qua', 2017, 120, 7.0999999046325684, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F033', N'Người Bất Tử', N'Người Bất Tử', 2018, 132, 6.6999998092651367, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F034', N'Passport to Love', N'Chuyện Tình Xa Xứ', 2009, 120, 6.5999999046325684, 0.17);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F035', N'Scandal: Bí Mật Thảm Đỏ', N'Scandal: Bí Mật Thảm Đỏ', 2012, 100, 6.9000000953674316, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F036', N'Chàng Vợ Của Em', N'Chàng Vợ Của Em', 2018, 120, 7.3000001907348633, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F037', N'Kiss of the Death', N'Nụ Hôn Thần Chết', 2008, 93, 6.3000001907348633, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F038', N'Scandal: Hào Quang Trở Lại', N'Scandal: Hào Quang Trở Lại', 2014, 110, 6.9000000953674316, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F039', N'Chuyện Của Pao', N'Chuyện của Pao', 2006, 98, 6.8000001907348633, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F040', N'Long Ruoi', N'Long Ruồi', 2011, 95, 6.1999998092651367, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F041', N'Đập Cánh Giữa Không Trung', N'Đập Cánh Giữ Không Trung ', 2014, 99, 6.9000000953674316, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F042', N'Cánh đồng hoang', N'Cánh Đồng Hoang', 1979, 90, 7.0999999046325684, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F043', N'Em bé Hà Nội', N'Em Bé Hà Nội', 1974, 72, 6.9000000953674316, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F044', N'Nhắm Mắt Thấy Mùa Hè', N'Nhắm Mắt Thấy Mùa Hè', 2018, 98, 6.8000001907348633, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F045', N'Âm Mưu Giày Gót Nhọn', N'Âm Mưu Giày Gót Nhọn', 2013, 91, 7, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F046', N'Goodbye Mother', N'Thưa Mẹ Con Đi', 2019, 106, 7.5, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F047', N'Sài Gòn Yo!', N'Sài Gòn Yo!', 2011, 106, 6.6999998092651367, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F048', N'Chang Trai Nam Ay', N'Chàng Trai Năm Ấy', 2014, 119, 6.1999998092651367, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F049', N'First Morning', N'Buổi Sáng Đầu Năm', 2003, 89, 6.6999998092651367, 0.04);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F050', N'Nuoc', N'Nước 2030', 2014, 98, 6, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F051', N'Lôi Báo', N'Lôi Báo', 2017, 107, 6, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F052', N'Thương Nhớ Đồng Quê', N'Thương Nhớ Đồng Quê', 1995, 116, 7.0999999046325684, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F053', N'Tien Chua', N'Tiền Chùa', 2013, 98, 7.8000001907348633, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F054', N'The Guava House', N'Mùa Ổi', 2000, 100, 7.1999998092651367, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F055', N'Sister Sister', N'Chị Chị Em Em', 2019, 104, 6.3000001907348633, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F056', N'Cưới Ngay Kẻo Lỡ', N'Cưới Ngay Kẻo Lỡ', 2012, 95, 6.4000000953674316, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F057', N'Mẹ Chồng', N'Mẹ Chồng', 2017, 90, 7.3000001907348633, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F058', N'Cua Lại Vợ Bầu', N'Cua Lại Vợ Bầu', 2019, 102, 5.9000000953674316, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F059', N'Đừng Đốt', N'Đừng Đốt', 2009, 100, 7.5, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F060', N'Dịu Dàng', N'Dịu Dàng', 2014, 100, 6.5, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F061', N'Để Mai Tính 2: Để Hội Tính', N'Để Mai Tính 2', 2014, 95, 6.0999999046325684, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F062', N'Sống Trong Sợ Hãi', N'Sống Trong Sợ Hãi', 2005, 110, 7.5999999046325684, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F063', N'Hương Ga', N'Hương Ga', 2014, 100, 5.9000000953674316, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F064', N'Cha Cõng Con', N'Cha Cõng Con', 2017, 90, 7.6999998092651367, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F065', N'1735 Km', N'1735 KM', 2005, 107, 7.4000000953674316, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F066', N'Hạt Mưa Rơi Bao Lâu', N'Hạt Mưa Rơi Bao Lâu', 2005, 114, 7.0999999046325684, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F067', N'Đời Cát', N'Đời Cát', 1999, 90, 7.3000001907348633, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F068', N'Vũ Khúc Con Cò', N'Vũ Khúc Con Cò', 2002, 111, 6.4000000953674316, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F069', N'Cô Dâu Đại Chiến 2', N'Cô Dâu Đại Chiến 2', 2014, 100, 6.1999998092651367, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F070', N'Người Truyền Giống', N'Người Truyền Thống', 2014, 87, 6.5999999046325684, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F071', N'Thất Sơn Tâm Linh', N'Thất Sơn Tâm Linh', 2019, 100, 5.9000000953674316, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F072', N'Jackpot', N'Trúng Số', 2015, 92, 6.5999999046325684, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F073', N'Quyên', N'Quyên', 2015, 105, 6.3000001907348633, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F074', N'Mê Thảo, Thời Vang Bóng', N'Mê Thảo, Thời Vang Bóng', 2002, 107, 7.5999999046325684, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F075', N'Ngọc Viễn Đông', N'Ngọc Viễn Đông', 2011, 103, 8, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F076', N'Hồn Papa Da Con Gái', N'Hồn Papa Da Con Gái', 2018, 113, 6.5999999046325684, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F077', N'Dành cho tháng Sáu', N'Dành Cho Tháng Sáu', 2012, 81, 7.6999998092651367, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F078', N'Trăng Nơi Đáy Giếng', N'Trăng Nơi Đáy Giếng', 2008, 121, 7.8000001907348633, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F079', N'Gánh Xiếc Rong', N'Gánh Xiếc Rong', 1988, 76, 6.9000000953674316, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F080', N'Chị Trợ Lý Của Anh', N'Chị Trợ Lý Của Anh', 2019, 113, 6.1999998092651367, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F081', N'Những Nụ Hôn Rực Rỡ', N'Những nụ hôn rực rỡ', 2010, 0, 6.4000000953674316, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F082', N'Lấy Chồng Người Ta', N'Lấy Chồng Người Ta', 2012, 115, 8, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F083', N'Yêu', N'Yêu', 2015, 106, 7.1999998092651367, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F084', N'Huyền Thoại Bất Tử', N'Huyền Thoại Bất Tử', 2009, 90, 7.0999999046325684, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F085', N'Thung Lũng Hoang Vắng', N'Thung Lũng Hoang Vắng', 2001, 90, 7.5, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F086', N'Hello Vietnam', N'Dạ Cổ Hoài Lang', 2017, 88, 7.3000001907348633, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F087', N'Lac Gioi', N'Lạc Giới', 2014, 93, 6.8000001907348633, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F088', N'Giao Lộ Định Mệnh', N'Giao Lộ Định Mệnh', 2010, 100, 6.1999998092651367, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F089', N'Dao cua dan ngu cu', N'Đảo Của Dân Ngụ Cư', 2017, 93, 6.4000000953674316, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F090', N'Saigon I Love You', N'Sài Gòn, Anh Yêu Em', 2016, 0, 6.3000001907348633, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F091', N'Nắng', N'Nắng', 2016, 100, 7.1999998092651367, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F092', N'Mùi Cỏ Cháy', N'Mùi Cỏ Cháy', 2012, 97, 8.1000003814697266, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F093', N'Lô Tô', N'Lô Tô', 2017, 90, 7, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F094', N'Trời Sáng Rồi, Ta Ngủ Đi Thôi', N'Trời Sáng Rồi, Ta Ngủ Đi Thôi', 2019, 93, 7.0999999046325684, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F095', N'She''s the Boss', N'Bạn Gái Tôi Là Sếp', 2017, 120, 6.0999999046325684, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F096', N'Anh Trai Yêu Quái', N'Anh Trai Yêu Quái', 2019, 107, 7.0999999046325684, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F097', N'Vĩ tuyến 17 ngày và đêm', N'Vĩ Tuyến 17, Ngày Và Đêm', 1973, 180, 8.3000001907348633, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F098', N'100 Ngày Bên Em', N'100 Ngày Bên Em', 2018, 99, 7.0999999046325684, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F099', N'Làng Vũ Đại ngày ay', N'Làng Vũ Đại Ngày Ấy', 1982, 89, 8.5, NULL);");
            Sql("INSERT INTO Films (FID, EnglishTitle, VietnameseTitle, Year, Length, Rating, Gross) VALUES (N'F100', N'Vua Bãi Rác', N'Vua Bãi Rác', 2002, 97, 6.8000001907348633, NULL);");
        }
        
        public override void Down()
        {
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public struct Course
{
    public string name;
    public string image_url;
    public string image_path;
    public string _path;
}

public class CoursesContainerController : MonoBehaviour {

    public GameObject courseCategoryBox;
    public float gridY = 5f;
    public float gridX = 5f;
    public float gridZ = 5f;
    public float spacing = 20f;

    public string[] courseNames =
    {
        "Bí quyết biến ý tưởng thành doanh thu, khởi nghiệp từ con số 0",
        "Thành thạo photoshop trong 7 ngày",
        "Excel cho người đi làm",
        "SEO website top 10 dễ dàng",
        "Kiếm tiền trên Youtube dễ dàng",
        "4 điểm vàng trong thuyết phục",
        "Kỹ năng thuyết trình & nghệ thuật gây ảnh hưởng",
        "Nói thoả thích 8 tiếng mỗi ngày mà không lo mất giọng",
        "Yoga trực tuyến - khỏe đẹp ngay tại nhà",
        "Học jQuery cơ bản đến nâng cao qua 20 bài tập",
        "Yoga giữ dáng giảm cân",
        "Giáo trình Finger Style ngắn nhất cho một quá trình lâu dài",
        "Sản xuất Video bán hàng bằng điện thoại",
        "Mất gốc tiếng Anh thì phải làm thế nào?",
        "Kỹ Năng Bán Hàng Chuyên Nghiệp",
        "Trọn bộ kiến thức NodeJS",
        "30 Ngày Tinh Thông Mind map",
        "IELTS Writing 5.0 cho người mới bắt đầu",
        "Điệu nhảy của những phím đàn piano",
        "Bán hàng trên ZALO - Sức hút trăm đơn 1 ngày",
        "Thiết kế và làm phim kiến trúc cực đỉnh với Revit & Lumion",
        "Học CorelDRAW cầm tay chỉ việc trong 3 giờ",
        "Ts. Lê Thẩm Dương - Quản trị cảm xúc",
        "Lập trình Android và Kiếm tiền từ tạo App",
        "Motion Graphic với After Effects",
        "Lớp học DJ Online",
        "Đầu tư cổ phiếu",
        "Khóa học SEO chuyên nghiệp từ cơ bản đến nâng cao",
        "Để viral video chinh phục cột mốc triệu view",
        "Ts. Lê Thẩm Dương - Chiến lược tài chính",
        "Thiền khí công - Bí quyết nâng cao sức khỏe",
        "Học nấu món ăn chay dưỡng sinh",
        "Ảo thuật với âm thanh cùng DJ số 1 Việt Nam",
        "Tuyệt chiêu đàm phán",
        "Khoá học Nghệ Thuật Bán hàng Trên Facebook A-Z",
        "Xây dựng nội dung trên Fanpage từ A đến Z",
        "Các kỹ thuật thuyết trình chuyên nghiệp",
        "Luyện phát âm chuẩn và giọng nói lôi cuốn",
        "Nhận diện bản tính và hành vi bẩm sinh (Ứng dụng khoa học Sinh trắc vân tay)",
        "Gây ấn tượng bằng kỹ năng tổ chức trò chơi trong sinh hoạt, thuyết trình, hội họp",
        "Tiếng Trung giao tiếp cho người mới bắt đầu",
        "Kỹ năng thuyết trình ấn tượng",
        "Trọn bộ 5 kỹ năng Tiếng Anh cơ bản",
        "Dựng nhân vật hoạt hình 3D với Blender",
        "Yoga cho mẹ bầu dễ sinh và khỏe mạnh",
        "Đạt 450+ TOEIC trong 3 giờ",
        "Làm chủ các kỹ năng tin học căn bản",
        "Tiếng Trung du lịch cấp tốc",
        "Hai giờ làm intro với Adobe After Effects",
        "Quảng cáo, bán hàng và kiếm tiền trên Facebook: Cơ bản",
        "Thiết kế kiến trúc chuyên nghiệp cùng Revit",
        "Lập trình C# trong 5 tuần - Cơ bản",
        "Khởi nghiệp từ tay trắng",
        "Luyện thi TOEIC 500+ cho người mới bắt đầu",
        "Yoga gìn giữ nét xuân - Chương trình trung cấp",
        "24 video đào tạo kỹ năng để thành công trong kinh doanh theo mạng",
        "Điện tử cơ bản (Phần 1)",
        "Yoga tránh béo phì và nguy cơ mắc bệnh tiểu đường cho bà bầu",
        "Dễ dàng đạt TOEIC Listening 750+",
        "Xây dựng Website Responsive và kiếm tiền với HTML5, CSS3",
        "Thiết lập cuộc hẹn qua 6 bước",
        "Học photoshop một cách bài bản để trở thành nhà thiết kế chuyên nghiệp",
        "Nhập môn Guitar điện cho người mới bắt đầu",
        "Khóa học làm phim - Sống với đam mê",
        "Yoga trị liệu đốt sống lưng, đốt sống cổ dành cho người bị thoái hóa cột sống và dân văn phòng",
        "Nhập môn nhiếp ảnh cho mọi người",
        "Nghệ thuật bán hàng trên Facebook A-Z nâng cao",
        "Giúp trẻ nâng cao tự đánh giá bản thân để thành công và hạnh phúc",
        "Lập trình C# trong 5 tuần - Nâng cao",
        "Trở thành cao thủ Toeic sau 9 giờ học online",
        "Học Tiếng Nhật sơ cấp 1 trong 5 giờ",
        "Kỹ năng viết bài PR bán hàng",
        "VBA for Civil Engineer Level 1",
        "Bí quyết xây dựng hệ thống thu nhập thụ động",
        "Làm chủ thiết kế với 3DS MAX 2017 và VRay",
        "Học làm móng gel cơ bản",
        "Sketchnote- Diễn hoạ thông tin bằng hình ảnh",
        "Nghệ thuật viết CV và phỏng vấn ứng tuyển",
        "Trọn bộ diễn họa kiến trúc nội thất từ A đến Z với 3Ds MAX, V-RAY và Photoshop",
        "Chỉnh sửa ảnh với camera raw từ a đến z",
        "Những điệu nhạc căn bản dành cho Guitar Modern",
        "3DSMAX - DỰNG HÌNH NỘI THẤT NÂNG CAO",
        "Học Piano hiệu quả theo phương pháp hiện đại",
        "Kinh doanh cửa hàng thời trang",
        "Guitar đệm hát dòng nhạc Bolero trong vòng 30 ngày",
        "Bí quyết chọn chồng để có một cuộc hôn nhân bền vững hạnh phúc",
        "Tự tin giao tiếp Tiếng Anh trong khối ngành kỹ thuật chỉ với 7 phút mỗi ngày",
        "Sexy Dance - Khỏe, Đẹp và Gợi cảm",
        "KHOÁ HỌC MARKETING ONLINE DÀNH CHO BẤT ĐỘNG SẢN",
        "9 Bước Chốt Hàng Trên Landing Page",
        "Võ tự vệ - Tay không chiến đấu",
        "Học nhảy cha cha cha cho người mới bắt đầu",
        "Bí mật thiền ứng dụng thay đổi cuộc sống",
        "Thiết kế 3D và bản vẽ 2D kỹ thuật nhanh chính xác với Autodesk Mechanical Desktop (MTD)",
        "Yoga phục hồi tự nhiên, chữa lành cuộc sống-hoàn thiện cuộc đời",
        "Hướng dẫn thiết kế web Wordpress chuẩn SEO",
        "Trình chiếu chuyên nghiệp với Powerpoint",
        "Bí Quyết Bán Hàng Trên Youtube",
        "Đệm hát Piano trong 30 ngày - Thiện Organ",
        "Thiết kế Banner chuyển động trên Web",
        "All in one, html/css3, bootstrap 4, và học cắt web từ file thiết kế qua 20 bài tập thực tế",
        "Làm chủ Photoshop - Hiện thực hóa giấc mơ",
        "Khóa học kiếm tiền đô tại nhà, bền vững cùng Youtube",
        "5 phút khỏe đẹp hấp dẫn mỗi ngày",
        "Những bài học vô giá mà bạn cần biết khi khởi nghiệp",
        "Thai giáo - Phát triển trí tuệ và cảm xúc cho con từ trong bụng mẹ",
        "Học Illustrator, photoshop và animate cc 2017 thông qua bài tập thực tế",
        "Bí quyết xây dựng và phát triển mối quan hệ",
        "Đồ da thủ công: Tự do sáng tạo những sản phẩm của riêng bạn",
        "Kỹ năng giải mã ngôn ngữ cơ thể nắm bắt tâm lý người khác",
        "Yoga cho sức khỏe trẻ lâu giữ mãi tuổi thanh xuân",
        "Làm chủ Sketchup - Xây dựng mô hình 3D trong thiết kế từ xây dựng đến nội thất",
        "Làm chủ C/C++ trong 4 tuần",
        "IELTS ăn liền: Cấp tốc chinh phục IELTS 5.5+",
        "Phương pháp giúp con học tập hiệu quả",
        "Bí quyết đạt điểm tuyệt đối bài thi TOEIC Reading",
        "Vũ khí marketing hiệu quả trong lĩnh vực F&B",
        "Daily Vietnamese conversation for foreigners",
        "Luyện thi tiếng Hàn KLPT 1",
        "Khởi nghiệp từ thương mại điện tử",
        "Docker cơ bản",
        "Bán hàng và kiếm tiền trên Facebook nâng cao",
        "Tiếng Anh giao tiếp cơ bản",
        "Điện tử cơ bản (Phần 2)",
        "Nghệ thuật thôi miên bằng ngôn từ",
        "Thuyết trình sáng tạo với công cụ Prezi",
        "Internet of Things Starter",
        "Bí mật 5 bước sở hữu 5000 khách hàng mỗi tháng từ Email Marketing",
        "Uốn tóc y học khỏe đẹp tự nhiên",
        "Bán hàng bằng cách thiết kế Landing Page siêu tốc với instapage và wordpress",
        "Chiến lược kinh doanh ngày Tết",
        "Luyện thi IELTS Writing task 2",
        "Thưởng thức rượu vang",
        "Làm chủ tiền bạc",
        "Dựng hình nhân vật 3DS Max",
        "Aerobic - Giữ gìn vóc dáng mùa lễ hội",
        "Laravel PHP Framework",
        "Xúc tiến thương mại qua hội chợ trong nước và quốc tế",
        "PowerPoint 2013/2016 Tips & Tricks: không chỉ là trình chiếu chuyên nghiệp",
        "Kế toán tổng hợp trên phần mềm Excel",
        "Khác biệt cùng PowerPoint",
        "GOOGLE ANALYTICS căn bản cho người mới bắt đầu",
        "Học bơi hai giờ",
        "PHONG THỦY KÍCH HOẠT TÀI LỘC NĂM 2017",
        "Marketing cho doanh nghiệp nhỏ",
        "Lập trình điều khiển cánh tay robot trong 7 ngày",
        "Handmade ứng dụng - F5 không gian sống",
        "Cẩm nang từ A-Z Illustrator cho Designer",
        "Trình chiếu bằng PowerPoint - Thật là đơn giản!",
        "Trái ngành thành thạo Photoshop",
    };

    public string[] courseUrls =
    {
        "http://d303ny97lru840.cloudfront.net/kelley-57bfb0d3ce4b1438274ba1fd/20160917-dungdd01/dungdd01-bi-quyet-kinh-doanh-cho-nguoi-khoi-nghiep.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57bfb0d3ce4b1438274ba1fd/20160917-huypq01_cl22_1-3_final/huypq01-thanh-thao-photoshop-trong-vong-7-ngay.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57bfb0d3ce4b1438274ba1fd/20160917-hoangvm02_cl22_09_03/thanhnd01-lam-viec-hieu-qua-va-nang-suat-hon-voi-excel.png",
        "http://d303ny97lru840.cloudfront.net/kelley-57bfb0d3ce4b1438274ba1fd/20160917-/hoangvm02-10-buoc-de-lam-seo.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57bfb0d3ce4b1438274ba1fd/20160922-anhnq01-youtube/anhnq.png",
        "http://d303ny97lru840.cloudfront.net/kelley-56a9c68fd8b7314bb80001b0/20170209-ngocnmanh/unnamed.png",
        "http://d303ny97lru840.cloudfront.net/kelley-574b9bc0047c99646f5ecbfd/20161117-ducla01/luuanhduc222.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57bfb0d3ce4b1438274ba1fd/20160917-anhnt01/anhtn01-noi-thoa-thich-8-tieng-moi-ngay-ma-khong-lo-mat-giong.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57bfb0d3ce4b1438274ba1fd/20160917-hieunyoga1lan-11807/hieun01-yoga-truc-tuyen-khoe-dep-ngay-tai-nha.png",
        "http://d303ny97lru840.cloudfront.net/kelley-57bfb0d3ce4b1438274ba1fd/20160921-vietnd02/vietnd03-hoc-jquery.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-578d9461047c9913c37c158a/20161226-anhkhoahoc_longtt/img_3525-copy.jpg",
        "http://d303ny97lru840.cloudfront.net/thailand-57e4def8ce4b145a1020dbf9/20161212-/31e32d93be0f2ac2cf246f3502c3043a.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57bfb0d3ce4b1438274ba1fd/20160917-kienlt01/kienlt01-san-xuat-video-ban-hang-bang-dien-thoai.png",
        "http://d303ny97lru840.cloudfront.net/kelley-56a9c68fd8b7314bb80001b0/20160908-anhnd01-bai-tap/anhnd-01-01.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20161209-/campt-lp-negotiation.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20160909-vunb02692016/the-big-firms-are-using-nodejs-for-web-and-mobile-app.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20161031-/logo-banner002.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57b29ff2ce4b146cc9444dd1/20160913-phuongpn01-ver-1/who-accepts-ielts3-1.png",
        "http://d303ny97lru840.cloudfront.net/kelley-57baf0c3ce4b145b7a16acac/20161006-trangpqanhgioithieu/img_4928.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-575fd3fb047c995cc4fdbef5/20160912-kiemnt02/maxresdefault.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20161116-tungpt02fix_16_11/rvt_2017_splashscreen.png",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20160929-loild03_29_9/unnamed.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57b46a0ece4b1438f2529364/20160909-duonglt12-9616/thumbnail-01.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57b818ee047c994c5d55be00/20161014-/tuanlq2.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20161003-/14536887_1316848761668005_1643086611_o.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20160928-mixx01-28092016/dj-mixx-thumbnail.png",
        "http://d303ny97lru840.cloudfront.net/kelley-57b46a0ece4b1438f2529364/20160923-/untitled-3-01.png",
        "http://d303ny97lru840.cloudfront.net/kelley-57b29ff2ce4b146cc9444dd1/20160910-tinhd-8916/seo-chuyen-nghiep-tu-co-ban-den-nang-cao.png",
        "http://d303ny97lru840.cloudfront.net/kelley-57b67684047c99584fc4a66e/20160916-anhbn01/viral-video.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20161126-/bai-1600_10_38_19still001.png",
        "http://d303ny97lru840.cloudfront.net/kelley-574672f1047c99646c5ec79f/20161110-dungnn01thienkhiconglan11011/thien-7.jpeg",
        "http://d303ny97lru840.cloudfront.net/kelley-57b67d6f60af25054a055b25/20160908-/6359655117817312111846422883_vegetarian-article-feature-pic3.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57b67d6f60af25054a055b25/20160831-cuongdj01djlan13008/309_cuong_2.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57b67684047c99584fc4a66e/20160914-longpt02/10-meo-dam-phan-khi-thue-van-phong-5.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-56a9c68fd8b7314bb80001b0/20160908-truonglv05-97/truonglv05-fix.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20161018-/thangk01.png",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20161012-/t0004.png",
        "http://d303ny97lru840.cloudfront.net/kelley-57b29ff2ce4b146cc9444dd1/20161007-hieunhk-anh/screen-shot-2016-10-07-at-43645-pm.png",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20160927-/hoangpm01.png",
        "http://d303ny97lru840.cloudfront.net/kelley-57b29ff2ce4b146cc9444dd1/20160930-hieunhk-anh/forca-de-trabalho.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57b67d6f60af25054a055b25/20160907-ngocnhlan1tiengtrunggiaotiep010709/learning_chinese.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57b29ff2ce4b146cc9444dd1/20160920-hieunhk-anh/thuyet-trinh.png",
        "http://d303ny97lru840.cloudfront.net/kelley-57b29ff2ce4b146cc9444dd1/20161005-vannnt01-1102016/2.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20161014-phuongkm01_baitapthuchanh/splash-final-edit_2-copy.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-574672f1047c99646c5ec79f/20161104-thuntm02anhgiangvienlan10411/7.png",
        "http://d303ny97lru840.cloudfront.net/kelley-577a160c047c994bb7e5b397/20161024-tuankm03_toeic_2410/toeic1.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20161129-/of8ovi0.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-577a160c047c994bb7e5b397/20161203-camnt03_anh/world___china__040541_.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20161018-/danglh.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-575fd3fb047c995cc4fdbef5/20161122-anhnp01-22112016/blog-facebook-marketing-tips-for-advertising.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20161215-hungps02_filedinhkem/cover.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57d0eeb7ce4b14556f8b28f7/20161122-thanhtd03-221116/74370-oeb5dx-501-01.png",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20161112-/unnamed.png",
        "http://d303ny97lru840.cloudfront.net/kelley-577a160c047c994bb7e5b397/20161028-anhdv_toeic_2610/sryhnsr.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20170104-ngocntb2_anhkhoahoc/loe_3142-1.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20161220-/hinh-topica.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20161129-/odr9vf0.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-574672f1047c99646c5ec79f/20161028-thuntm01yogababaugiamcanlan12810/313263587.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-577a160c047c994bb7e5b397/20161125-alphabook_2511-anh/bia-listening-1.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57b818ee047c994c5d55be00/20161109-/html5-css3-01.png",
        "http://d303ny97lru840.cloudfront.net/kelley-57d0eeb7ce4b14556f8b28f7/20170105-daotg01-281216/boss-management-meeting-ss-1920-800x450.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20160929-loild03-289/maxresdefault.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-56a9c68fd8b7314bb80001b0/20161214-/guitar-wallpaper-7446-hd.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20161114-/cover.png",
        "http://d303ny97lru840.cloudfront.net/kelley-577a160c047c994bb7e5b397/20161125-longtt_2511-anh/anh-cong-vien-3.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20161112-hungnh01_anh/34082-nzfwow00.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20161125-/14761-nprv44.png",
        "http://d303ny97lru840.cloudfront.net/kelley-574b9bc0047c99646f5ecbfd/20161031-/20151030_mevacon_day-tre-hoc-am-nhac-khi-con-be-1024x684.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57d0eeb7ce4b14556f8b28f7/20161122-thanhtd04-221116/74370-oeb5dx-501-798.png",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20161221-hangnt201_fix_21_12/anh-khoa-hoc000.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-577a160c047c994bb7e5b397/20161129-sofl02_2511-intro/1608_special_toto_main.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57d0eeb7ce4b14556f8b28f7/20161129-tuanpd01-291116/med-public-relations.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20170109-/b800_00_02_25still001.png",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20161228-khoicv_anh/su-that-ve-thu-nhap-thu-dong.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20170111-dongtd01-11012016/max-wallpaper.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-577a160c047c994bb7e5b397/20170106-/cac-mau-ve-mong-tay-chan-gia-1.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57b67684047c99584fc4a66e/20161126-sketchnote/sketchnote-handbook-sketchnotes-page-2.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57b29ff2ce4b146cc9444dd1/20161026-tiendt01-251016/cv-tiendt2.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20161205-tungnt4_anh/interior_hauki.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20161119-/adobe_logo.png",
        "http://d303ny97lru840.cloudfront.net/kelley-57d0eeb7ce4b14556f8b28f7/20161108-ngocnda01-81116/pexels-photo-109123.jpeg",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20161206-thinhdt02_chuong56_612/autodesk-3ds-max-1280x720.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57aeff66047c99460637fe96/20161129-hieuvd_2411/cach-cai-thien-nhanh-chong-ky-nang-choi-dan-piano9.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-578d9461047c9913c37c158a/20170111-1112017hangntd01/62818-oacmc5-951-01.png",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20170104-/25007111.png",
        "http://d303ny97lru840.cloudfront.net/kelley-578862be047c997a3a7c1526/20161018-maivh01/3.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20161229-tuanpn01-29122016/gear-backgrounds.png",
        "http://d303ny97lru840.cloudfront.net/kelley-577a160c047c994bb7e5b397/20161230-zoie---anh-khoa-hoc/1365146770-ca-sy-hq--10-.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20161228-hoangvm08_28_12/images23125_bat_dong_san.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57d0eeb7ce4b14556f8b28f7/20161203-binhdn02-21216/11004-nn4u8y-01.png",
        "http://d303ny97lru840.cloudfront.net/kelley-574672f1047c99646c5ec79f/20161018-/maxresdefault-1.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-574672f1047c99646c5ec79f/20161107-anhclv01chachachalan10711/original_159242_afox3pbdrbbrhp_iqvayh6yhn.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-574672f1047c99646c5ec79f/20161027-hieun01thienungdunglan12710/14117950_1598837773749413_1355769218834942242_n.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57d0eeb7ce4b14556f8b28f7/20161125-nghiemdx01-161116/4291-02.png",
        "http://d303ny97lru840.cloudfront.net/kelley-578d9461047c9913c37c158a/20161226-anhkhoahoc_longtt/img_3514-copy.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20161123-/khoa-hoc-thiet-ket-website-wordpress-chuan-seo-le-van-truong.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20161209-thanhvt03_912/maxresdefault.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20161128-/hinh-anh-khoa-hoc-ban-hang-tu-youtube-phi-o-dong-le-van-truong.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57d0eeb7ce4b14556f8b28f7/20170105-chanhlt02-3117/90541-763263oiv4qf-310.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20170118-/slide-gioi-thieu-khoa-hoc.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57b67d6e60af25054a055b21/20161207-vietnd09-ver2/446134_383c.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20161230-/banner-khoa-hoc.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20170116-truonglv09-16012017/bai-3100_00_00_00still001.png",
        "http://d303ny97lru840.cloudfront.net/kelley-577a160c047c994bb7e5b397/20170103-hoant2---anh/hoant2---anh-gioi-thieu.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57d0eeb7ce4b14556f8b28f7/20161222-vudd01-211216/bai-600_00_02_24still001.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20161122-/thumbnail.png",
        "http://d303ny97lru840.cloudfront.net/kelley-56a9c68fd8b7314bb80001b0/20170104-/designer-struggles.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57d0eeb7ce4b14556f8b28f7/20161224-linhpk01-231216/thumbnail-linhpk01-01.png",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20170103-/dolio.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20161208-/body-language-fact.png",
        "http://d303ny97lru840.cloudfront.net/kelley-578d9461047c9913c37c158a/20161226-anhkhoahoc_longtt/img_3523-copy.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20161215-dainb02_15_12/sketchuplogo.png",
        "http://d303ny97lru840.cloudfront.net/kelley-57d0eeb7ce4b14556f8b28f7/20161223-datdt01-231216/oezgcf1-01.png",
        "http://d303ny97lru840.cloudfront.net/kelley-577a160c047c994bb7e5b397/20170103-hangmun312017/15036427_1131015613673119_39016288165120364_n.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-574b9bc0047c99646f5ecbfd/20161121-/cach-day-con-hoc-tot.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-577a160c047c994bb7e5b397/20161125-alphabook_2511-anh/bia-reading-1.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57b67684047c99584fc4a66e/20161012-tungh01/sfg.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20170110-/o9iy4711.png",
        "http://d303ny97lru840.cloudfront.net/kelley-577a160c047c994bb7e5b397/20170121-kpltanh/111121114558-south-korea-student-college-exam-horizontal-large-gallery.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-575fd3fb047c995cc4fdbef5/20161122-/5-xu-huong-thuong-mai-dien-tu-tren-di-dong2.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20161128-tungnt401_cacbaikhac/docker-large-h-trans.png",
        "http://d303ny97lru840.cloudfront.net/kelley-575fd3fb047c995cc4fdbef5/20161122-anhnp01-22112016/facebook-money-revenue-dollars2-fade-ss-1920.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20161203-/08.png",
        "http://d303ny97lru840.cloudfront.net/kelley-57b67d6f60af25054a055b25/20161212-vinhvv02anh/mach-dien-tu.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20161221-/business-107.png",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20161212-tungts01_12_10/prezi-blue-logo-1920x1080px.png",
        "http://d303ny97lru840.cloudfront.net/kelley-56a9c68fd8b7314bb80001b0/20161230-vinhdt01-3012/internet-of-things-fotolia.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-56a9c68fd8b7314bb80001b0/20170103-/email-marketing-from-tree-frog-international.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57b67d6f60af25054a055b25/20161227-tuantn01lamtoc2712/anh-gt.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57b67d6e60af25054a055b21/20170106-vietnd10-chuong-1/screen-shot-2012-04-17-at-125444-pm.png",
        "http://d303ny97lru840.cloudfront.net/kelley-57d0eeb7ce4b14556f8b28f7/20170110-duynt03-10117/82857-oh8f0u-804-01.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-577a160c047c994bb7e5b397/20170111-linhuk/how-to-write-an-essay.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-56a9c68fd8b7314bb80001b0/20170216-/ruou-vang.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-5774fe0a047c990d2bf5aa0b/20170117-thanhnd201-1012017/man-with-money.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57ac2d8c047c990776574ffe/20170209-/trang-bia.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57e4def8ce4b145a1020dbf9/20170110-lienntt01-10012017/fitness-wallpaper-1080p-hd.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-56a9c68fd8b7314bb80001b0/20170118-/laravel.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57d0eeb7ce4b14556f8b28f7/20170117-duynt04-17117/14612-npq2x9-01.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20170121-hoantn_21_1/ppt-tips--tricks-cover.png",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20170203-/ke-toan-excel.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57d0eeb7ce4b14556f8b28f7/20170117-dongnt03-17117/powerpoint.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57b67684047c99584fc4a66e/20170118-thanhpn01-1812017/google-analytics-name2-1920.png",
        "http://d303ny97lru840.cloudfront.net/kelley-57d0eeb7ce4b14556f8b28f7/20170119-duyna01-19117/2be532032c2f2b2522daa3297be02bce.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20170118-phongthuy_18_1/thietkelogophongthuy.png",
        "http://d303ny97lru840.cloudfront.net/kelley-57d0eeb7ce4b14556f8b28f7/20170120-duynt05-21117/85231-ohck2p-16-01.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20170206-/mommy-robot.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-577a160c047c994bb7e5b397/20170124-hoantn01---anh-gioi-thieu/unnamed-3.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57ac2d8c047c990776574ffe/20170203-duypd03-3217/16466305_10154345091061314_1581837792_o.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-57b67d6e60af25054a055b21/20170210-thanhdvh01-09022017/microsoft-powerpoint-courses-2013-training-uk-digital-academy.jpg",
        "http://d303ny97lru840.cloudfront.net/kelley-5768aeb1047c995f75fdbf6b/20170207-anhph02_8_2/maxresdefault.jpg",
    };

    public string[] courseImages = {
        "1.1.png",
        "1.2.bmp",
        "1.3.png",
        "1.4.png",
        "1.5.jpg",
        "1.6.png",
        "1.7.png",
        "1.8.bmp",
        "1.11.bmp",
        "1.12.png",
        "1.13.bmp",
        "1.14.bmp",
        "1.16.bmp",
        "1.22.jpg",
        "2.1.bmp",
        "2.2.bmp",
        "2.3.bmp",
        "2.4.bmp",
        "2.5.bmp",
        "2.6.jpg",
        "2.7.jpg",
        "2.8.jpg",
        "2.9.jpg",
        "2.10.bmp",
        "2.11.jpg",
        "2.12.jpg",
        "2.13.bmp",
        "2.14.jpg",
        "2.15.jpg",
        "2.16.png",
        "2.17.jpg",
        "2.18.jpg",
        "2.19.jpg",
        "2.20.jpg",
        "2.21.jpg",
        "2.22.jpg",
        "2.23.jpg",
        "2.24.jpb",
        "2.25.jpg",
        "2.26.jpg",
        "2.27.jpg",
        "2.28.jpg",
        "2.29.jpg",
        "2.30.jpg",
        "2.31.png",
        "2.32.jpeg",
        "2.34.jpg",
        "2.35.png",
        "2.36.jpg",
        "2.38.jpg",
        "3.1.bmp",
        "3.2.bmp",
        "3.3.bmp",
        "3.6.png",
        "3.8.png",
        "3.9.png",
        "3.10.png",
        "3.11.jpg",
        "3.11.png",
        "3.12.png",
        "3.13.jpg",
        "3.14.jpg",
        "3.15.jpg",
        "3.16.jpg",
        "3.17.jpg",
        "3.18.jpg",
        "3.19.jpg",
        "3.20.jpg",
        "3.21.jpg",
        "3.22.jpg",
        "3.23.jpg",
        "3.24.jpg",
        "3.25.png",
        "3.26.png",
        "3.27.jpg",
        "3.28.jpg",
        "3.29.jpg",
        "3.30.png",
        "3.31.jpg",
        "3.32.jpg",
        "3.3.jpg",
        "3.34.png",
        "4.1.bmp",
        "4.2.png",
        "4.3.bmp",
        "4.4.bmp",
        "4.5.bmp",
        "4.6.bmp",
        "4.8.bmp",
        "4.9.bmp",
        "4.12.bmp",
        "4.13.png",
        "4.14.jpg",
        "4.15.jpg",
        "4.16.png",
        "4.17.jpg",
        "4.18.jpg",
        "4.19.jpg",
        "4.20.jpg",
        "4.21.jpg",
        "4.22.jpg",
        "4.23.png",
        "4.26.jpg",
        "4.27.png",
        "4.28.jpg",
        "4.29.jpg",
        "4.30.png",
        "4.31.jpg",
        "4.32.png",
        "4.33.jpg",
        "4.34.png",
        "4.35.jpg",
        "4.36.png",
        "4.37.png",
        "4.38.jpg",
        "4.39.jpg",
        "4.40.png",
        "4.41.jpg",
        "4.42.png",
        "4.44.jpg",
        "5.1.bmp",
        "5.1.jpg",
        "5.2.bmp",
        "5.3.bmp",
        "5.4.bmp",
        "5.5.bmp",
        "5.6.bmp",
        "5.7.bmp",
        "5.8.bmp",
        "5.9.bmp",
        "5.13.bmp",
        "5.14.png",
        "5.15.jpg",
        "5.16.jpg",
        "5.17.png",
        "5.18.jpg",
        "5.19.jpg",
        "5.20.jpg",
        "5.21.jpg",
        "5.22.bmp",
        "5.23.png",
        "5.24.png",
        "5.25.jpg",
        "5.26.jpg",
        "5.27.jpg",
        "5.28.jpg",
        "5.29.jpg",
        "5.30.png",
        "5.31.jpg",
        "5.32.jpg",
    };

    public string[] courseImagePaths = {
        "1.1",
        "1.2",
        "1.3",
        "1.4",
        "1.5",
        "1.6",
        "1.7",
        "1.8",
        "1.11",
        "1.12",
        "1.13",
        "1.14",
        "1.16",
        "1.22",
        "2.1",
        "2.2",
        "2.3",
        "2.4",
        "2.5",
        "2.6",
        "2.7",
        "2.8",
        "2.9",
        "2.10",
        "2.11",
        "2.12",
        "2.13",
        "2.14",
        "2.15",
        "2.16",
        "2.17",
        "2.18",
        "2.19",
        "2.20",
        "2.21",
        "2.22",
        "2.23",
        "2.24",
        "2.25",
        "2.26",
        "2.27",
        "2.28",
        "2.29",
        "2.30",
        "2.31",
        "2.32",
        "2.34",
        "2.35",
        "2.36",
        "2.38",
        "3.1",
        "3.2",
        "3.3",
        "3.6",
        "3.8",
        "3.9",
        "3.10",
        "3.11",
        "3.11",
        "3.12",
        "3.13",
        "3.14",
        "3.15",
        "3.16",
        "3.17",
        "3.18",
        "3.19",
        "3.20",
        "3.21",
        "3.22",
        "3.23",
        "3.24",
        "3.25",
        "3.26",
        "3.27",
        "3.28",
        "3.29",
        "3.30",
        "3.31",
        "3.32",
        "3.33",
        "3.34",
        "4.1",
        "4.2",
        "4.3",
        "4.4",
        "4.5",
        "4.6",
        "4.8",
        "4.9",
        "4.12",
        "4.13",
        "4.14",
        "4.15",
        "4.16",
        "4.17",
        "4.18",
        "4.19",
        "4.20",
        "4.21",
        "4.22",
        "4.23",
        "4.26",
        "4.27",
        "4.28",
        "4.29",
        "4.30",
        "4.31",
        "4.32",
        "4.33",
        "4.34",
        "4.35",
        "4.36",
        "4.37",
        "4.38",
        "4.39",
        "4.40",
        "4.41",
        "4.42",
        "4.44",
        "5.1",
        "5.1",
        "5.2",
        "5.3",
        "5.4",
        "5.5",
        "5.6",
        "5.7",
        "5.8",
        "5.9",
        "5.13",
        "5.14",
        "5.15",
        "5.16",
        "5.17",
        "5.18",
        "5.19",
        "5.20",
        "5.21",
        "5.22",
        "5.23",
        "5.24",
        "5.25",
        "5.26",
        "5.27",
        "5.28",
        "5.29",
        "5.30",
        "5.31",
        "5.32",
    };

    public Course[] courses;
    public Texture2D[] texs;

    public static int texIndex = 0;

    // Use this for initialization
    void Start () {
        initialCourses();

        texs = new Texture2D[courses.Length];
        for (int i = 0; i < courses.Length; i++)
        {
            //Texture2D tex = new Texture2D(4, 4, TextureFormat.DXT1, false);
            //WWW www = new WWW(courses[i].image_url);
            //yield return www;
            //www.LoadImageIntoTexture(tex);

            //texs[i] = LoadPNG("./Assets/Resources/" + courses[i].image_path);

            texs[i] = (Texture2D)Resources.Load(courses[i]._path);
        }

        for (int y = 0; y < gridY; y++)
        {
            Vector3 pos = new Vector3(0, y * spacing, 0);
            GameObject clone = (GameObject)Instantiate(courseCategoryBox, pos, Quaternion.identity);
            clone.transform.parent = transform;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void initialCourses()
    {
        int length = courseNames.Length < courseUrls.Length ? courseNames.Length : courseUrls.Length;
        length = length < courseImages.Length ? length : courseImages.Length;
        length = length < courseImagePaths.Length ? length : courseImagePaths.Length;

        courses = new Course[length];

        for (int i = 0; i < length; i++)
        {
            Course course;
            course.name = courseNames[i];
            course.image_url = courseUrls[i];
            course.image_path = courseImages[i];
            course._path = courseImagePaths[i];

            courses[i] = course;
        }
    }

    IEnumerator initialTexs()
    {
        texs = new Texture2D[courses.Length];
        for (int i = 0; i < courses.Length; i++)
        {
            Texture2D tex = new Texture2D(4, 4, TextureFormat.DXT1, false);
            WWW www = new WWW(courses[i].image_url);
            yield return www;
            www.LoadImageIntoTexture(tex);

            texs[i] = tex;
        }
    }

    public static Texture2D LoadPNG(string filePath)
    {

        Texture2D tex = null;
        byte[] fileData;

        if (File.Exists(filePath))
        {
            fileData = File.ReadAllBytes(filePath);
            tex = new Texture2D(2, 2);
            tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.
        }
        return tex;
    }
}

import 'package:flutter/material.dart';
import 'package:marketuygulamasi/urun_detay.dart';

class Kategori extends StatefulWidget {
  final String kategori;

  const Kategori({Key key, this.kategori}) : super(key: key);
  @override
  _KategoriState createState() => _KategoriState();
}

class _KategoriState extends State<Kategori> {
  List<Widget> gosterilecekListe;

  @override
  void initState() {
    super.initState();

    if (widget.kategori == "Temel gıda") {
      gosterilecekListe = [
        urunKarti("Sebze", "10 TL",
            "https://cdn.pixabay.com/photo/2015/05/04/10/16/vegetables-752153_1280.jpg",
            mevcut: true,),
        urunKarti("Sebze", "10 TL",
            "https://cdn.pixabay.com/photo/2015/05/04/10/16/vegetables-752153_1280.jpg"),
        urunKarti("Sebze", "10 TL",
            "https://cdn.pixabay.com/photo/2015/05/04/10/16/vegetables-752153_1280.jpg"),
        urunKarti("Sebze", "10 TL",
            "https://cdn.pixabay.com/photo/2015/05/04/10/16/vegetables-752153_1280.jpg"),
        urunKarti("Sebze", "10 TL",
            "https://cdn.pixabay.com/photo/2015/05/04/10/16/vegetables-752153_1280.jpg"),
      ];
    } else if (widget.kategori == "Şekerleme") {
      gosterilecekListe = [
        urunKarti("Sebze", "10 TL",
            "https://cdn.pixabay.com/photo/2015/05/04/10/16/vegetables-752153_1280.jpg"),
        urunKarti("Sebze", "10 TL",
            "https://cdn.pixabay.com/photo/2015/05/04/10/16/vegetables-752153_1280.jpg"),
        urunKarti("Sebze", "10 TL",
            "https://cdn.pixabay.com/photo/2015/05/04/10/16/vegetables-752153_1280.jpg"),
        urunKarti("Sebze", "10 TL",
            "https://cdn.pixabay.com/photo/2015/05/04/10/16/vegetables-752153_1280.jpg"),
      ];
    }
    if (widget.kategori == "İçecekler") {
      gosterilecekListe = [
        urunKarti("Sebze", "10 TL",
            "https://cdn.pixabay.com/photo/2015/05/04/10/16/vegetables-752153_1280.jpg"),
        urunKarti("Sebze", "10 TL",
            "https://cdn.pixabay.com/photo/2015/05/04/10/16/vegetables-752153_1280.jpg"),
        urunKarti("Sebze", "10 TL",
            "https://cdn.pixabay.com/photo/2015/05/04/10/16/vegetables-752153_1280.jpg"),
        urunKarti("Sebze", "10 TL",
            "https://cdn.pixabay.com/photo/2015/05/04/10/16/vegetables-752153_1280.jpg"),
        urunKarti("Sebze", "10 TL",
            "https://cdn.pixabay.com/photo/2015/05/04/10/16/vegetables-752153_1280.jpg"),
      ];
    }
    if (widget.kategori == "Temizlik") {
      gosterilecekListe = [
        urunKarti("Sebze", "10 TL",
            "https://cdn.pixabay.com/photo/2015/05/04/10/16/vegetables-752153_1280.jpg"),
        urunKarti("Sebze", "10 TL",
            "https://cdn.pixabay.com/photo/2015/05/04/10/16/vegetables-752153_1280.jpg"),
        urunKarti("Sebze", "10 TL",
            "https://cdn.pixabay.com/photo/2015/05/04/10/16/vegetables-752153_1280.jpg"),
        urunKarti("Sebze", "10 TL",
            "https://cdn.pixabay.com/photo/2015/05/04/10/16/vegetables-752153_1280.jpg"),
        urunKarti("Sebze", "10 TL",
            "https://cdn.pixabay.com/photo/2015/05/04/10/16/vegetables-752153_1280.jpg"),
      ];
    }
  }

  Widget urunKarti(String isim, String fiyat, String resim,{bool mevcut=false}) {
    return GestureDetector(
      onTap: (){
        Navigator.push(context, MaterialPageRoute(builder: (context)=>UrunDetay( isim: isim,
      fiyat: fiyat,
      resim: resim,
      mevcut: mevcut,),),);
     
      },
      child: Container(
        decoration: BoxDecoration(
          borderRadius: BorderRadius.circular(20.0),
          color: Colors.white,
          boxShadow: [
            BoxShadow(
              color: Colors.grey.withOpacity(0.2),
              blurRadius: 4.0,
              spreadRadius: 2.0,
            ),
          ],
        ),
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Container(
              width: 120.0,
              height: 80.0,
              decoration: BoxDecoration(
                image: DecorationImage(
                  image: NetworkImage(resim),
                  fit: BoxFit.cover,
                ),
                borderRadius: BorderRadius.circular(20.0),
              ),
            ),
            SizedBox(
              height: 8.0,
            ),
            Text(
              isim,
              style: TextStyle(
                fontSize: 14.0,
                fontWeight: FontWeight.bold,
                color: Colors.grey[600],
              ),
            ),
            SizedBox(
              height: 8.0,
            ),
            Text(
              fiyat,
              style: TextStyle(
                fontSize: 14.0,
                fontWeight: FontWeight.bold,
                color: Colors.blue[300],
              ),
            ),
          ],
        ),
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return GridView.count(
      crossAxisCount: 2,
      mainAxisSpacing: 12.0,
      crossAxisSpacing: 12.0,
      padding: EdgeInsets.all(10.0),
      childAspectRatio: 1,
      children: gosterilecekListe,
    );
  }
}

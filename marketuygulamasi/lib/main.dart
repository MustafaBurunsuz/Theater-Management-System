import 'package:flutter/material.dart';
import 'package:marketuygulamasi/sepetim.dart';
import 'package:marketuygulamasi/urunler.dart';

void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Projem',
      theme: ThemeData(
        primarySwatch: Colors.green,
      ),
      home: Anasayfa(),
    );
  }
}

class Anasayfa extends StatefulWidget {
  @override
  _AnasayfaState createState() => _AnasayfaState();
}

class _AnasayfaState extends State<Anasayfa> {
  int _aktificerikNo=0;
  List _icerikler;
  @override
  void initState() {
    super.initState();
    _icerikler = [
      Urunler(),
      Sepetim(),
    ];
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.white,
      appBar: AppBar(
        iconTheme: IconThemeData(color: Colors.blue[300]),
        backgroundColor: Colors.white,
        elevation: 0.0,
        centerTitle: true,
        title: Text(
          "Uçarak Gelsin",
          style: TextStyle(
            fontSize: 20.0,
            fontWeight: FontWeight.bold,
            color: Colors.grey,
          ),
        ),
      ),
      drawer: Drawer(
        child: ListView(
          padding:EdgeInsets.all(0.0) ,
          children: [
          UserAccountsDrawerHeader(accountName: Text("Mustafa Burunsuz") , accountEmail: Text("mustafaburunsuz1@gmail.com",),
          currentAccountPicture: Container(decoration: BoxDecoration(image: 
          DecorationImage(image: NetworkImage("https://cdn.pixabay.com/photo/2016/12/13/05/15/puppy-1903313_1280.jpg",),
          fit: BoxFit.cover,
          ),
          borderRadius: BorderRadius.circular(50.0),
          ),),
          decoration: BoxDecoration(color: Colors.blue[300]),
          ),
          ListTile(title: Text("Siparişlerim"), onTap: (){},),
            ListTile(title: Text("İndirimlerim"), onTap: (){},),
              ListTile(title: Text("Ayarlar"), onTap: (){},),
                ListTile(title: Text("Çıkış Yap"), onTap: (){
                  Navigator.pop(context);
                },),
        ],
        ),
      ),
      body: _icerikler[_aktificerikNo],
      bottomNavigationBar: BottomNavigationBar(
        currentIndex: _aktificerikNo,
        selectedItemColor: Colors.blue[300],
        unselectedItemColor: Colors.grey[600],
        items: [BottomNavigationBarItem(icon: Icon(Icons.home),label: "Ürünler", ),
        BottomNavigationBarItem(icon: Icon(Icons.shopping_cart),label: "Sepetim", ),
      ],
      onTap: (int tiklananButonPozisyonNo){
      setState(() {
                _aktificerikNo=tiklananButonPozisyonNo;
            });
        
      },
      ),
    );
  }
}

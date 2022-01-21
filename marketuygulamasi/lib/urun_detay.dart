import 'package:flutter/material.dart';

class UrunDetay extends StatelessWidget {
  final String isim;
   final String fiyat;
    final String resim;
    final bool mevcut;

  const UrunDetay({Key key, this.isim, this.fiyat, this.resim, this.mevcut}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: ListView(
        children: [
          Stack(
            children: [
              Image.network(
              resim),
              IconButton(
                icon: Icon(
                  Icons.arrow_back,
                  color: Colors.blue[300],
                  size: 40.0,
                ),
                onPressed: () {
                  Navigator.pop(context);
                },
              ),
            ],
          ),
          Column(
            children: [
              SizedBox(
                height: 20.0,
              ),
              Text(
                isim,
                style: TextStyle(
                  fontSize: 20.0,
                  fontWeight: FontWeight.bold,
                ),
              ),
              SizedBox(
                height: 10.0,
              ),
              Text(
                fiyat,
                style: TextStyle(
                  fontSize: 20.0,
                  fontWeight: FontWeight.bold,
                  color: Colors.blue[300],
                ),
              ),
              SizedBox(
                height: 20.0,
              ),
              Padding(
                padding: const EdgeInsets.only(left:15.0,right: 15.0,),
                child: Text("Ürünün kalite bilgileriii..",
                textAlign: TextAlign.center, style: TextStyle(
                    fontSize: 16.0,
                    fontWeight: FontWeight.bold,
                    color: Colors.grey,
                  ),),
              ),
              SizedBox(
                height: 25.0,
              ),
              Container(
                width: MediaQuery.of(context).size.width -50,
                height: 50.0,
                decoration:BoxDecoration(
                color: mevcut ? Colors.blue[300] : Colors.black,
                
                 borderRadius: BorderRadius.circular(12.0),
              ),
              child:  Center(
                child: Text(
                  mevcut? "Sepete Ekle" : "Stokta Yok",
                  style: TextStyle(
                    fontSize: 20.0,
                    fontWeight: FontWeight.bold,
                    color: Colors.white,
                  ),
                ),
              ),
              ),
              
            ],
          ),
        ],
      ),
    );
  }
}

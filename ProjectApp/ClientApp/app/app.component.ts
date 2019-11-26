import { Component, OnInit } from '@angular/core';
import { DataService } from './data.service';
import { Goods} from './goods';

import { HttpResponse } from '@angular/common/http';

@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    providers: [DataService]
})

export class AppComponent implements OnInit {

    
    goods: Goods = new Goods();   // изменяемый товар
    goodsArr: Goods[];                // массив товаров
    tableMode: boolean = true;          // табличный режим

     
    
    constructor(private dataService: DataService) { }

    ngOnInit() {
        this.loadProducts();    // загрузка данных при старте компонента  
    }
    // получаем данные через сервис
    loadProducts() {
        this.dataService.getProducts()
            .subscribe((data: Goods[]) => this.goodsArr = data);
       
    }
    // сохранение данных
    save() {
        if (this.goods.id == null)
        {
            this.dataService.createProduct(this.goods)
                .subscribe((data: Goods) => this.goodsArr.push(data));
                
        }
        else
        {
            this.dataService.updateProduct(this.goods)
                .subscribe(data => this.loadProducts());
        }
        this.cancel();
    }
    editProduct(g: Goods) {
        this.goods = g;
    }
    cancel() {
        this.goods = new Goods();
        this.tableMode = true;
    }
    delete(g: Goods) {
        this.dataService.deleteProduct(g.id)
            .subscribe(data => this.loadProducts());
    }
    add() {
        this.cancel();
        this.tableMode = false;
    }
}
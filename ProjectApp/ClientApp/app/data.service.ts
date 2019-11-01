import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Goods } from './goods';

@Injectable()
export class DataService {

    private url = "/api/products";

    constructor(private http: HttpClient) {
    }

    getProducts() {
        return this.http.get(this.url);
    }

    createProduct(goods: Goods) {
        return this.http.post(this.url, goods);
    }
    updateProduct(goods: Goods) {
        return this.http.put(this.url + '/' + goods.id, goods);
    }
    deleteProduct(id: number) {
        return this.http.delete(this.url + '/' + id);
    }
}
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
import { Component } from '@angular/core';
import { DataService } from './data.service';
import { Goods } from './goods';
var AppComponent = /** @class */ (function () {
    function AppComponent(dataService) {
        this.dataService = dataService;
        this.goods = new Goods(); // изменяемый товар
        this.tableMode = true; // табличный режим
    }
    AppComponent.prototype.ngOnInit = function () {
        this.loadProducts(); // загрузка данных при старте компонента  
    };
    // получаем данные через сервис
    AppComponent.prototype.loadProducts = function () {
        var _this = this;
        this.dataService.getProducts()
            .subscribe(function (data) { return _this.goodsArr = data; });
    };
    // сохранение данных
    AppComponent.prototype.save = function () {
        var _this = this;
        if (this.goods.id == null) {
            this.dataService.createProduct(this.goods)
                .subscribe(function (data) { return _this.goodsArr.push(data); });
        }
        else {
            this.dataService.updateProduct(this.goods)
                .subscribe(function (data) { return _this.loadProducts(); });
        }
        this.cancel();
    };
    AppComponent.prototype.editProduct = function (g) {
        this.goods = g;
    };
    AppComponent.prototype.cancel = function () {
        this.goods = new Goods();
        this.tableMode = true;
    };
    AppComponent.prototype.delete = function (g) {
        var _this = this;
        this.dataService.deleteProduct(g.id)
            .subscribe(function (data) { return _this.loadProducts(); });
    };
    AppComponent.prototype.add = function () {
        this.cancel();
        this.tableMode = false;
    };
    AppComponent = __decorate([
        Component({
            selector: 'app',
            templateUrl: './app.component.html',
            providers: [DataService]
        }),
        __metadata("design:paramtypes", [DataService])
    ], AppComponent);
    return AppComponent;
}());
export { AppComponent };
//# sourceMappingURL=app.component.js.map
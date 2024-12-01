import { HttpClient, HttpParams } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { Observable } from 'rxjs';
import { Product } from '../../models/product';
import { CreateEditProduct } from '../../models/createEditProduct';
import { ProductEditContext } from '../../models/productEditContext';
import { ProductFiltersContext } from '../../models/productFiltersContext';
import { BaseApi } from './base-api';
import { Exercise } from '../../models/exercise';

@Injectable({
  providedIn: 'root'
})
export class ExercisesApiService extends BaseApi {
  private http = inject(HttpClient);
  private baseApi = environment.apiUrl;

  get(): Observable<Exercise[]> {
    return this.http.get<Exercise[]>(this.baseApi + 'exercises');
  }

  getEditContext(productId: number | undefined): Observable<ProductEditContext> {
    let params = new HttpParams();
    if (productId) {
      params = params.append('id', productId);
    }
    return this.http.get<ProductEditContext>(this.baseApi + 'product/editor', { params });
  }

  create(model: CreateEditProduct): Observable<Product> {
    return this.http.post<Product>(this.baseApi + 'products', model);
  }

  edit(id: number, model: CreateEditProduct): Observable<Product> {
    return this.http.put<Product>(this.baseApi + `products/${id}`, model);
  }

  delete(id: number): Observable<void> {
    return this.http.delete<void>(this.baseApi + `products/${id}`);
  }
}

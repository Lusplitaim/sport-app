import { inject, Injectable } from '@angular/core';
import { ExercisesApiService } from './api/exercises-api.service';
import { Observable } from 'rxjs';
import { Exercise } from '../models/exercise';

@Injectable({
  providedIn: 'root'
})
export class ExercisesService {
  private exercisesService = inject(ExercisesApiService);

  get(): Observable<Exercise[]> {
    return this.exercisesService.get();
  }

  /* getEditContext(productId: number | undefined): Observable<ProductEditContext> {
    return this.productsApi.getEditContext(productId);
  }

  getFiltersContext(): Observable<ProductFiltersContext> {
    return this.productsApi.getFiltersContext();
  }

  create(model: CreateEditProduct): Observable<Product> {
    return this.productsApi.create(model);
  }

  edit(id: number, model: CreateEditProduct): Observable<Product> {
    return this.productsApi.edit(id, model);
  }

  delete(id: number): Observable<void> {
    return this.productsApi.delete(id);
  } */
}

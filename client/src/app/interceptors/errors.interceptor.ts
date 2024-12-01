import { HttpInterceptorFn } from '@angular/common/http';
import { inject } from '@angular/core';
import { Router } from '@angular/router';
import { catchError } from 'rxjs';

export const errorsInterceptor: HttpInterceptorFn = (req, next) => {
  //const toastService = inject(ToastService);

  return next(req).pipe(
    catchError(error => {
      if (error) {
        switch (error.status) {
          case 400:
            const errMessage = error.error.errors[0].message;
            //toastService.showDanger("Error", errMessage ?? "Unknown validation error");
            break;
          case 403:
            //toastService.showDanger("Error", "Forbidden");
            break;
        }
      }

      throw error;
    })
  );
};

import { Authentication } from "./authentication.model";
import { Injectable, NgModule } from "@angular/core";
import { HttpRequest, HttpHandler, HttpEvent, HttpInterceptor, HTTP_INTERCEPTORS } from "@angular/common/http";
import { Observable } from "rxjs";

@Injectable()
export class JwtInterceptor implements HttpInterceptor {
    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        // add authorization header with jwt token if available
        const currentUser: Authentication = JSON.parse(localStorage.getItem("usuarioLogado"));
        console.log("currentUser");

        if (currentUser) {
            request = request.clone({
                setHeaders: {
                    Authorization: `Bearer ${currentUser.accessToken}`,
                }
            });
        } else {
            console.error("Não foi identificado um usário logado");
        }

        return next.handle(request);
    }
}

@NgModule({
    providers: [
        {
            provide: HTTP_INTERCEPTORS,
            useClass: JwtInterceptor,
            multi: true,
        },
    ],
})
export class Interceptor { }

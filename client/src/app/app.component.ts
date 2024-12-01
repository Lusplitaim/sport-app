import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MenuItem } from 'primeng/api';
import { MenubarModule } from 'primeng/menubar';
import { GlobalRoutePath } from './app.routes';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, MenubarModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  menuItems: MenuItem[] = [
    {
      label: "Schedule",
      routerLink: this.getRouterLink(GlobalRoutePath.Schedule),
    },
  ];

  private getRouterLink(path: string): string {
    return `/${path}`;
  }
}

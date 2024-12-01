import { Routes } from '@angular/router';
import { ScheduleComponent } from './components/schedule/schedule.component';

export const routes: Routes = [
    {
        path: '',
        redirectTo: GlobalRoutePath.Schedule,
        pathMatch: 'full',
    },
    {
        path: '',
        children: [
            {
                path: GlobalRoutePath.Schedule,
                component: ScheduleComponent,
            },
        ],
    },
];

export const enum GlobalRoutePath {
    Schedule = 'schedule',
};

import { Component, inject, OnInit } from '@angular/core';
import { FullCalendarModule } from '@fullcalendar/angular';
import { CalendarOptions, EventSourceInput } from '@fullcalendar/core/index.js';
import dayGridPlugin from '@fullcalendar/daygrid';
import interactionPlugin, { DateClickArg } from '@fullcalendar/interaction';
import { ExercisesService } from '../../services/exercises.service';
import { Exercise } from '../../models/exercise';
import { DialogService, DynamicDialogConfig, DynamicDialogRef } from 'primeng/dynamicdialog';
import { ExercisesDashboardComponent } from '../exercises-dashboard/exercises-dashboard.component';
import { DialogEditResult } from '../../models/dialogEditResult';

@Component({
  selector: 'app-schedule',
  standalone: true,
  imports: [FullCalendarModule],
  templateUrl: './schedule.component.html',
  styleUrl: './schedule.component.scss'
})
export class ScheduleComponent implements OnInit {
  private exercisesService = inject(ExercisesService);
  private exercises: Exercise[] = [];
  private dialogRef: DynamicDialogRef | undefined;
  private dialogService = inject(DialogService);

  calendarOptions: CalendarOptions = {
    plugins: [dayGridPlugin, interactionPlugin],
    initialView: 'dayGridMonth',
    weekends: true,
    dateClick: (arg: DateClickArg) => console.log(arg.dateStr),
  };

  ngOnInit(): void {
    this.exercisesService.get().subscribe(exs => {    
      this.exercises = exs;
      let events = exs.map((ex) => { 
        return { title: 'Rand event', start: ex.date };
       });
      this.calendarOptions.events = events;
    });
  }
  
  openDashboardModal() {
    const dialogConfig = {
      header: ``,
      width: '20vw',
      modal: true,
      closeOnEscape: true,
      breakpoints: {
          '960px': '75vw',
          '640px': '90vw'
      },
    } as DynamicDialogConfig<number[]>;
    
    dialogConfig.header = 'Создание продукта';

    this.dialogRef = this.dialogService.open(ExercisesDashboardComponent, dialogConfig);

    this.dialogRef.onClose.subscribe((data: DialogEditResult<Product>) => {
      if (data) {
        this.products.push(data.result);
      }
    });
  }

}

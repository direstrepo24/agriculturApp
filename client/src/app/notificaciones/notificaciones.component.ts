import { Component, Injector } from '@angular/core';
import { NotificacionesGenerated } from './notificaciones-generated.component';

@Component({
  selector: 'notificaciones',
  templateUrl: './notificaciones.component.html'
})
export class NotificacionesComponent extends NotificacionesGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}

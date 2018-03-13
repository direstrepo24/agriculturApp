import { Component, Injector } from '@angular/core';
import { AddTypeNotificationGenerated } from './add-type-notification-generated.component';

@Component({
  selector: 'add-type-notification',
  templateUrl: './add-type-notification.component.html'
})
export class AddTypeNotificationComponent extends AddTypeNotificationGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}

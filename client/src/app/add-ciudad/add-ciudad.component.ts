import { Component, Injector } from '@angular/core';
import { AddCiudadGenerated } from './add-ciudad-generated.component';

@Component({
  selector: 'add-ciudad',
  templateUrl: './add-ciudad.component.html'
})
export class AddCiudadComponent extends AddCiudadGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}

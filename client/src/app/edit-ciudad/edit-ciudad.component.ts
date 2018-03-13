import { Component, Injector } from '@angular/core';
import { EditCiudadGenerated } from './edit-ciudad-generated.component';

@Component({
  selector: 'edit-ciudad',
  templateUrl: './edit-ciudad.component.html'
})
export class EditCiudadComponent extends EditCiudadGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}

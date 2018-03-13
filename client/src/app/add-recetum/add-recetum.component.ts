import { Component, Injector } from '@angular/core';
import { AddRecetumGenerated } from './add-recetum-generated.component';

@Component({
  selector: 'add-recetum',
  templateUrl: './add-recetum.component.html'
})
export class AddRecetumComponent extends AddRecetumGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}

import { Component, Injector } from '@angular/core';
import { AddFotoGenerated } from './add-foto-generated.component';

@Component({
  selector: 'add-foto',
  templateUrl: './add-foto.component.html'
})
export class AddFotoComponent extends AddFotoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}

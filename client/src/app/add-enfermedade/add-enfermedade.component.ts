import { Component, Injector } from '@angular/core';
import { AddEnfermedadeGenerated } from './add-enfermedade-generated.component';

@Component({
  selector: 'add-enfermedade',
  templateUrl: './add-enfermedade.component.html'
})
export class AddEnfermedadeComponent extends AddEnfermedadeGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}

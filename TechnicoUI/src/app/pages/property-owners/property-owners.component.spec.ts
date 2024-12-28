import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PropertyOwnersComponent } from './property-owners.component';

describe('PropertyOwnersComponent', () => {
  let component: PropertyOwnersComponent;
  let fixture: ComponentFixture<PropertyOwnersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PropertyOwnersComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PropertyOwnersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

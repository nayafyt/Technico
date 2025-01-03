import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { RepairsService } from '../../../services/repairs.service';
import { IRepairs } from '../../models/irepairs';
import { PaginationService } from '../../../services/pagination.service';

@Component({
  selector: 'app-search-results-page',
  imports: [CommonModule],
  templateUrl: './search-results-page.component.html',
  styleUrls: ['./search-results-page.component.scss'],
})
export class SearchResultsPageComponent implements OnInit {
  filteredRepairs: IRepairs[] = [];
  paginatedRepairs: IRepairs[] = [];
  isLoading = true;
  searchCriteria = {
    startDate: '',
    endDate: '',
    userId: '',
  };
  currentPage = 1;
  itemsPerPage = 3;
  totalPages = 0;

  constructor(
    private paginationService: PaginationService,
    private route: ActivatedRoute,
    private repairsService: RepairsService
  ) {}

  ngOnInit(): void {
    this.route.queryParams.subscribe((params) => {
      const startDate = params['startDate'];
      const userId = params['userId'];

      if ((startDate != '') || (userId != '')) {
        this.repairsService.getRepairs().subscribe((data) => {
          this.filteredRepairs = data.filter((repair) => {
            const matchStartDate = !startDate || new Date(repair.date).getTime() === new Date(startDate).getTime();
            const matchUserId = !userId || repair.userId === userId;
            return matchStartDate && matchUserId;
          });
          this.isLoading = false;
          this.updatePagination();
        });
      } else {
        this.isLoading = false;
      }
    });
  }

  updatePagination(): void {
    const { paginatedItems, totalPages } = this.paginationService.paginate(
      this.filteredRepairs,
      this.currentPage,
      this.itemsPerPage
    );
    this.paginatedRepairs = paginatedItems;
    this.totalPages = totalPages;
  }

  changePage(page: number): void {
    if (page < 1 || page > this.totalPages) {
      return;
    }
    this.currentPage = page;
    this.updatePagination();
  }

  get totalPagesList(): number[] {
    return Array.from({ length: this.totalPages }, (_, i) => i + 1);
  }
}
import { SortOrder } from "../../util/SortOrder";

export type EventOrderByInput = {
  createdAt?: SortOrder;
  dateTime?: SortOrder;
  eventTypeId?: SortOrder;
  id?: SortOrder;
  updatedAt?: SortOrder;
  value?: SortOrder;
};

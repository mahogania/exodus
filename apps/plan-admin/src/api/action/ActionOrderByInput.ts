import { SortOrder } from "../../util/SortOrder";

export type ActionOrderByInput = {
  createdAt?: SortOrder;
  id?: SortOrder;
  objectId?: SortOrder;
  updatedAt?: SortOrder;
};

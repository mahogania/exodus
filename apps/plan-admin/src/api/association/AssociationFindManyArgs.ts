import { AssociationWhereInput } from "./AssociationWhereInput";
import { AssociationOrderByInput } from "./AssociationOrderByInput";

export type AssociationFindManyArgs = {
  where?: AssociationWhereInput;
  orderBy?: Array<AssociationOrderByInput>;
  skip?: number;
  take?: number;
};

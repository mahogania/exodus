import { AssociationTypeWhereInput } from "./AssociationTypeWhereInput";
import { AssociationTypeOrderByInput } from "./AssociationTypeOrderByInput";

export type AssociationTypeFindManyArgs = {
  where?: AssociationTypeWhereInput;
  orderBy?: Array<AssociationTypeOrderByInput>;
  skip?: number;
  take?: number;
};

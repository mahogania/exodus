import { AssociationCreateNestedManyWithoutAssociationTypesInput } from "./AssociationCreateNestedManyWithoutAssociationTypesInput";
import { InputJsonValue } from "../../types";

export type AssociationTypeCreateInput = {
  associations?: AssociationCreateNestedManyWithoutAssociationTypesInput;
  schema?: InputJsonValue;
};

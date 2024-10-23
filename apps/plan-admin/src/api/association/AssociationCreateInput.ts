import { AssociationTypeWhereUniqueInput } from "../associationType/AssociationTypeWhereUniqueInput";
import { ObjectCreateNestedManyWithoutAssociationsInput } from "./ObjectCreateNestedManyWithoutAssociationsInput";
import { InputJsonValue } from "../../types";

export type AssociationCreateInput = {
  associationType?: AssociationTypeWhereUniqueInput | null;
  object?: ObjectCreateNestedManyWithoutAssociationsInput;
  value?: InputJsonValue;
};

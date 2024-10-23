import { AssociationTypeWhereUniqueInput } from "../associationType/AssociationTypeWhereUniqueInput";
import { ObjectUpdateManyWithoutAssociationsInput } from "./ObjectUpdateManyWithoutAssociationsInput";
import { InputJsonValue } from "../../types";

export type AssociationUpdateInput = {
  associationType?: AssociationTypeWhereUniqueInput | null;
  object?: ObjectUpdateManyWithoutAssociationsInput;
  value?: InputJsonValue;
};

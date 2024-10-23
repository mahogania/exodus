import { AssociationType } from "../associationType/AssociationType";
import { Object } from "../object/Object";
import { JsonValue } from "type-fest";

export type Association = {
  associationType?: AssociationType | null;
  createdAt: Date;
  id: string;
  object?: Array<Object>;
  updatedAt: Date;
  value: JsonValue;
};

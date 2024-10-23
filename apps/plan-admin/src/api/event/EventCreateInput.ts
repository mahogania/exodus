import { EventTypeWhereUniqueInput } from "../eventType/EventTypeWhereUniqueInput";
import { InputJsonValue } from "../../types";

export type EventCreateInput = {
  dateTime?: Date | null;
  eventType?: EventTypeWhereUniqueInput | null;
  value?: InputJsonValue;
};

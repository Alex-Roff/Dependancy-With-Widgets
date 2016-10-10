use DepWithWidgets
go


create schema Widget
go

create table Widget.States
(
  StateID int not null identity(1,1),
  StateName nvarchar(50) not null,
  StateTax float not null,
  ActiveBit bit not null
);

create table Widget.Widget
(
  WidgetID int not null identity(1,1),
  Name nvarchar(250) not null,
  BasePrice float not null,
  Discount bit not null,
  ActiveBit bit not null
);

alter table Widget.States
  add constraint pk_states_stateID primary key clustered (StateID);
alter table Widget.Widget
  add constraint pk_widget_widgetID primary key clustered (WidgetID);

alter table Widget.States
  add constraint df_states_activebit default (1) for ActiveBit;
alter table Widget.Widget
  add constraint df_widget_activebit default (1) for ActiveBit;

insert into Widget.States(StateName, StateTax) values ('Alabama', 4);
insert into Widget.States(StateName, StateTax) values ('Alaska', 0);
insert into Widget.States(StateName, StateTax) values ('Arizona', 5.6);
insert into Widget.States(StateName, StateTax) values ('Arkansas', 6.5);
insert into Widget.States(StateName, StateTax) values ('California', 7.5);
insert into Widget.States(StateName, StateTax) values ('Colorado', 2.9);
insert into Widget.States(StateName, StateTax) values ('Connecticut', 6.35);
insert into Widget.States(StateName, StateTax) values ('Delaware', 0);
insert into Widget.States(StateName, StateTax) values ('District of Columbia', 5.75);
insert into Widget.States(StateName, StateTax) values ('Florida', 6);
insert into Widget.States(StateName, StateTax) values ('Georgia', 4);
insert into Widget.States(StateName, StateTax) values ('Hawaii', 4);
insert into Widget.States(StateName, StateTax) values ('Idaho', 6);
insert into Widget.States(StateName, StateTax) values ('Illinois', 6.25);
insert into Widget.States(StateName, StateTax) values ('Indiana', 7);
insert into Widget.States(StateName, StateTax) values ('Iowa', 6);
insert into Widget.States(StateName, StateTax) values ('Kansas', 6.5);
insert into Widget.States(StateName, StateTax) values ('Kentucky', 6);
insert into Widget.States(StateName, StateTax) values ('Louisiana', 5);
insert into Widget.States(StateName, StateTax) values ('Maine', 5.5);
insert into Widget.States(StateName, StateTax) values ('Maryland', 6);
insert into Widget.States(StateName, StateTax) values ('Massachusetts', 6.25);
insert into Widget.States(StateName, StateTax) values ('Michigan', 6);
insert into Widget.States(StateName, StateTax) values ('Minnesota', 6.875);
insert into Widget.States(StateName, StateTax) values ('Mississippi', 7);
insert into Widget.States(StateName, StateTax) values ('Missouri', 4.225);
insert into Widget.States(StateName, StateTax) values ('Montana', 0);
insert into Widget.States(StateName, StateTax) values ('Nebraska', 5.5);
insert into Widget.States(StateName, StateTax) values ('Nevada', 6.85);
insert into Widget.States(StateName, StateTax) values ('New Hampshire', 0);
insert into Widget.States(StateName, StateTax) values ('New Jersey', 7);
insert into Widget.States(StateName, StateTax) values ('New Mexico', 5.125);
insert into Widget.States(StateName, StateTax) values ('New York', 4);
insert into Widget.States(StateName, StateTax) values ('North Carolina', 4.75);
insert into Widget.States(StateName, StateTax) values ('North Dakota', 5);
insert into Widget.States(StateName, StateTax) values ('Ohio', 5.75);
insert into Widget.States(StateName, StateTax) values ('Oklahoma', 4.5);
insert into Widget.States(StateName, StateTax) values ('Oregon', 0);
insert into Widget.States(StateName, StateTax) values ('Pennsylvania', 6);
insert into Widget.States(StateName, StateTax) values ('Rhode Island', 7);
insert into Widget.States(StateName, StateTax) values ('South Carolina', 6);
insert into Widget.States(StateName, StateTax) values ('South Dakota', 4.5);
insert into Widget.States(StateName, StateTax) values ('Tennessee', 7);
insert into Widget.States(StateName, StateTax) values ('Texas', 6.25);
insert into Widget.States(StateName, StateTax) values ('Utah', 4.7);
insert into Widget.States(StateName, StateTax) values ('Vermont', 6);
insert into Widget.States(StateName, StateTax) values ('Virginia', 4.3);
insert into Widget.States(StateName, StateTax) values ('Washington', 6.5);
insert into Widget.States(StateName, StateTax) values ('West Virginia', 6);
insert into Widget.States(StateName, StateTax) values ('Wisconsin', 5);
insert into Widget.States(StateName, StateTax) values ('Wyoming', 4);
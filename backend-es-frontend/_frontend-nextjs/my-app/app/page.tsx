"use client";
import { useEffect, useState } from "react";
import { Button } from "@/components/ui/button";
import { Card, CardContent } from "@/components/ui/card";
import { Input } from "@/components/ui/input";
import { Label } from "@/components/ui/label";

type Ingatlan = {
  id: number;
  category: string;
  seller: string;
  description: string;
  createAt: string;
  imageUrl: string;
};

export default function RealEstateApp() {
  const [ingatlanok, setIngatlanok] = useState<Ingatlan[]>([]);
  const [selectedId, setSelectedId] = useState<number | null>(null); // 🆕

  const [formData, setFormData] = useState({
    kategoria: "",
    elado: "",
    leiras: "",
    hirdetesDatuma: "",
    tehermentes: false,
    kepUrl: "",
    terulet: "",
    szobak: "",
    emeletek: "",
    koordinatak: ""
  });

  const fetchIngatlanok = async () => {
    const res = await fetch("http://localhost:3000/api/ingatlan");
    const data = await res.json();
    setIngatlanok(data);
  };

  useEffect(() => {
    fetchIngatlanok();
  }, []);

  const handleDelete = async (id: number) => {
    await fetch(`http://localhost:3000/api/ingatlan/${id}`, {
      method: "DELETE",
    });
    fetchIngatlanok();
  };

  const handleEdit = (id: number) => {
    const adat = ingatlanok.find(i => i.id === id);
    if (adat) {
      setSelectedId(id);
      setFormData({
        kategoria: adat.category,
        elado: adat.seller,
        leiras: adat.description,
        hirdetesDatuma: adat.createAt,
        tehermentes: false,
        kepUrl: adat.imageUrl,
        terulet: "",
        szobak: "",
        emeletek: "",
        koordinatak: ""
      });
    }
  };

  const resetForm = () => {
    setSelectedId(null);
    setFormData({
      kategoria: "",
      elado: "",
      leiras: "",
      hirdetesDatuma: "",
      tehermentes: false,
      kepUrl: "",
      terulet: "",
      szobak: "",
      emeletek: "",
      koordinatak: ""
    });
  };

  const handleSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();

    const url = selectedId
      ? `http://localhost:3000/api/ingatlan/${selectedId}`
      : "http://localhost:3000/api/ujingatlan";

    const method = selectedId ? "PUT" : "POST";

    await fetch(url, {
      method,
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(formData)
    });

    resetForm();
    fetchIngatlanok();
  };

  return (
    <div className="p-6 space-y-8">
      <h1 className="text-3xl font-bold">🏠 Ingatlan kezelő</h1>

      <Card>
        <CardContent className="p-4">
          <h2 className="text-xl font-semibold mb-4">
            {selectedId ? "✏️ Ingatlan szerkesztése" : "➕ Új ingatlan hozzáadása"}
          </h2>
          <form onSubmit={handleSubmit} className="grid grid-cols-1 md:grid-cols-2 gap-4">
            {Object.entries(formData).map(([key, value]) => (
              <div key={key} className="flex flex-col">
                <Label htmlFor={key}>{key}</Label>
                {typeof value === "boolean" ? (
                  <input
                    type="checkbox"
                    id={key}
                    checked={value}
                    onChange={(e) => setFormData({ ...formData, [key]: e.target.checked })}
                  />
                ) : (
                  <Input
                    id={key}
                    value={value}
                    onChange={(e) => setFormData({ ...formData, [key]: e.target.value })}
                  />
                )}
              </div>
            ))}
            <div className="flex gap-2">
              <Button type="submit">
                {selectedId ? "Frissítés" : "Mentés"}
              </Button>
              {selectedId && (
                <Button type="button" variant="secondary" onClick={resetForm}>
                  Mégse
                </Button>
              )}
            </div>
          </form>
        </CardContent>
      </Card>

      <Card>
        <CardContent className="p-4">
          <h2 className="text-xl font-semibold mb-4">📋 Ingatlan lista</h2>
          <table className="w-full table-auto border">
            <thead>
              <tr>
                <th className="border px-2">#</th>
                <th className="border px-2">Kategória</th>
                <th className="border px-2">Eladó</th>
                <th className="border px-2">Leírás</th>
                <th className="border px-2">Dátum</th>
                <th className="border px-2">Kép</th>
                <th className="border px-2">Műveletek</th>
              </tr>
            </thead>
            <tbody>
              {ingatlanok.map((i) => (
                <tr key={i.id} className="border">
                  <td className="border px-2">{i.id}</td>
                  <td className="border px-2">{i.category}</td>
                  <td className="border px-2">{i.seller}</td>
                  <td className="border px-2">{i.description}</td>
                  <td className="border px-2">{i.createAt}</td>
                  <td className="border px-2">
                    <img src={i.imageUrl} alt="ingatlan" className="w-16 h-16 object-cover" />
                  </td>
                  <td className="border px-2 flex gap-2">
                    <Button onClick={() => handleEdit(i.id)} variant="default">
                      Szerkesztés
                    </Button>
                    <Button onClick={() => handleDelete(i.id)} variant="destructive">
                      Törlés
                    </Button>
                  </td>
                </tr>
              ))}
            </tbody>
          </table>
        </CardContent>
      </Card>
    </div>
  );
}

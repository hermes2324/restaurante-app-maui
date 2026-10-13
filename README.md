<h1 align="center">🍽️ Restaurante App · .NET MAUI</h1>

<p align="center">
  App multiplataforma para un restaurante: los clientes piden desde su teléfono,<br />
  los meseros atienden las mesas y el administrador controla el menú y los pedidos en tiempo real.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/C%23-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/.NET%20MAUI-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET MAUI" />
  <img src="https://img.shields.io/badge/Supabase-3ECF8E?style=for-the-badge&logo=supabase&logoColor=white" alt="Supabase" />
  <img src="https://img.shields.io/badge/Firebase-FFCA28?style=for-the-badge&logo=firebase&logoColor=black" alt="Firebase" />
  <img src="https://img.shields.io/badge/Google%20Sign--In-4285F4?style=for-the-badge&logo=google&logoColor=white" alt="Google Sign-In" />
</p>

---

## ✨ Funciones

| 👤 Cliente | 🧑‍🍳 Mesero | 🛠️ Administrador |
|---|---|---|
| Ver el menú por categoría | Seleccionar la mesa | Agregar y editar productos |
| Carrito de compra | Levantar órdenes en mesa | Ver el historial de pedidos |
| Pedido a domicilio o en mesa | Ver el detalle de cada orden | Filtrar por tipo de entrega |
| Seguir el estado de sus órdenes | Recibir avisos de pedidos | Cambiar estado y pago de pedidos |

- 🔐 **Inicio de sesión** con correo o con **cuenta de Google** (OAuth con PKCE)
- ⚡ **Notificaciones en tiempo real** con Supabase Realtime y **push** con Firebase Cloud Messaging
- 📱 Una sola base de código para **Android, iOS, Windows y macOS**

## 🧱 Tecnologías

- **App:** C#, .NET MAUI 9, XAML, patrón con controladores y servicios
- **Datos:** Supabase (PostgreSQL) con `supabase-csharp` / `postgrest-csharp`
- **Notificaciones:** Plugin.Firebase.CloudMessaging y Plugin.LocalNotification
- **UI:** Syncfusion .NET MAUI DataGrid

## 🚀 Cómo correrlo

1. Instala **Visual Studio 2022** con la carga de trabajo **.NET MAUI**.
2. Crea tu archivo de claves (no se sube a GitHub):

   ```bat
   copy "RestauranteNoseCual\Base de Datos\Secretos.cs.ejemplo" "RestauranteNoseCual\Base de Datos\Secretos.cs"
   ```

   y llena en `Secretos.cs`:

   | Clave | Dónde se obtiene |
   |---|---|
   | `SupabaseUrl`, `SupabaseKey` | Supabase → *Project Settings → API* (usa la clave **anon**) |
   | `GoogleClientSecret` | Google Cloud Console → *APIs y servicios → Credenciales* |
   | `SyncfusionLicense` | Tu cuenta de Syncfusion (la licencia Community es gratuita) |

3. Para Android, descarga `google-services.json` desde la consola de Firebase y ponlo en `RestauranteNoseCual/Platforms/Android/`.
4. Abre `RestauranteNoseCual.sln` y ejecuta en el emulador o en tu teléfono.

## 🗂️ Estructura

```text
RestauranteNoseCual/
├── View/            ← pantallas XAML (menú, carrito, mesas, pedidos, perfil…)
├── Controllers/     ← lógica de cada pantalla
├── Services/        ← sesión, órdenes, mesas, notificaciones
├── Models/          ← entidades (pedido, mesa, cliente, producto…)
├── Base de Datos/   ← conexión a Supabase y login con Google
└── Platforms/       ← código específico de Android, iOS, Windows y macOS
```

## 👥 Equipo

Proyecto escolar del **TecNM Campus Guasave**, hecho por [Hermes Verdugo](https://github.com/hermes2324) y [RamonCarrillo90](https://github.com/RamonCarrillo90).

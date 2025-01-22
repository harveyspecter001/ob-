using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B3F RID: 2879
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapExtendedCoordinates : IMessage<MapExtendedCoordinates>, IMessage, IEquatable<MapExtendedCoordinates>, IDeepCloneable<MapExtendedCoordinates>, IBufferMessage
	{
		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x060089C8 RID: 35272 RVA: 0x00267910 File Offset: 0x00265B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MapExtendedCoordinates> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x060089C9 RID: 35273 RVA: 0x00267920 File Offset: 0x00265B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x060089CA RID: 35274 RVA: 0x00267930 File Offset: 0x00265B30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060089CB RID: 35275 RVA: 0x00267940 File Offset: 0x00265B40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapExtendedCoordinates()
		{
		}

		// Token: 0x060089CC RID: 35276 RVA: 0x00267950 File Offset: 0x00265B50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapExtendedCoordinates(MapExtendedCoordinates other)
		{
		}

		// Token: 0x060089CD RID: 35277 RVA: 0x00267960 File Offset: 0x00265B60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapExtendedCoordinates Clone()
		{
			return null;
		}

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x060089CE RID: 35278 RVA: 0x00267970 File Offset: 0x00265B70
		// (set) Token: 0x060089CF RID: 35279 RVA: 0x00267980 File Offset: 0x00265B80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int WorldX
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x060089D0 RID: 35280 RVA: 0x00267990 File Offset: 0x00265B90
		// (set) Token: 0x060089D1 RID: 35281 RVA: 0x002679A0 File Offset: 0x00265BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WorldY
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x060089D2 RID: 35282 RVA: 0x002679B0 File Offset: 0x00265BB0
		// (set) Token: 0x060089D3 RID: 35283 RVA: 0x002679C0 File Offset: 0x00265BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MapId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x060089D4 RID: 35284 RVA: 0x002679D0 File Offset: 0x00265BD0
		// (set) Token: 0x060089D5 RID: 35285 RVA: 0x002679E0 File Offset: 0x00265BE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SubAreaId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060089D6 RID: 35286 RVA: 0x002679F0 File Offset: 0x00265BF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060089D7 RID: 35287 RVA: 0x00267A00 File Offset: 0x00265C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapExtendedCoordinates other)
		{
			return true;
		}

		// Token: 0x060089D8 RID: 35288 RVA: 0x00267A10 File Offset: 0x00265C10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060089D9 RID: 35289 RVA: 0x00267A20 File Offset: 0x00265C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060089DA RID: 35290 RVA: 0x00267A30 File Offset: 0x00265C30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060089DB RID: 35291 RVA: 0x00267A40 File Offset: 0x00265C40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060089DC RID: 35292 RVA: 0x00267A50 File Offset: 0x00265C50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060089DD RID: 35293 RVA: 0x00267A60 File Offset: 0x00265C60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapExtendedCoordinates other)
		{
		}

		// Token: 0x060089DE RID: 35294 RVA: 0x00267A70 File Offset: 0x00265C70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060089DF RID: 35295 RVA: 0x00267A80 File Offset: 0x00265C80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060089E0 RID: 35296 RVA: 0x00267A90 File Offset: 0x00265C90
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapExtendedCoordinates()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				MapExtendedCoordinates._parser = new MessageParser<MapExtendedCoordinates>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x060089E1 RID: 35297 RVA: 0x00267B5C File Offset: 0x00265D5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zwMP5lJdhpkakMTPuY83()
		{
			return true;
		}

		// Token: 0x060089E2 RID: 35298 RVA: 0x00267B64 File Offset: 0x00265D64
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapExtendedCoordinates nQqABGJdrOey8xN9IGYc()
		{
			return null;
		}

		// Token: 0x040032BD RID: 12989
		private static readonly MessageParser<MapExtendedCoordinates> _parser;

		// Token: 0x040032BE RID: 12990
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032BF RID: 12991
		public const int WorldXFieldNumber = 1;

		// Token: 0x040032C0 RID: 12992
		private int worldX_;

		// Token: 0x040032C1 RID: 12993
		public const int WorldYFieldNumber = 2;

		// Token: 0x040032C2 RID: 12994
		private int worldY_;

		// Token: 0x040032C3 RID: 12995
		public const int MapIdFieldNumber = 3;

		// Token: 0x040032C4 RID: 12996
		private long mapId_;

		// Token: 0x040032C5 RID: 12997
		public const int SubAreaIdFieldNumber = 4;

		// Token: 0x040032C6 RID: 12998
		private int subAreaId_;

		// Token: 0x040032C7 RID: 12999
		private static MapExtendedCoordinates yLwpeJJdWhu5kRqoIOeG;
	}
}

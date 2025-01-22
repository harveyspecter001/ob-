using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B3D RID: 2877
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapCoordinates : IMessage<MapCoordinates>, IMessage, IEquatable<MapCoordinates>, IDeepCloneable<MapCoordinates>, IBufferMessage
	{
		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x060089AC RID: 35244 RVA: 0x002676F0 File Offset: 0x002658F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MapCoordinates> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x060089AD RID: 35245 RVA: 0x00267700 File Offset: 0x00265900
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x060089AE RID: 35246 RVA: 0x00267710 File Offset: 0x00265910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060089AF RID: 35247 RVA: 0x00267720 File Offset: 0x00265920
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapCoordinates()
		{
		}

		// Token: 0x060089B0 RID: 35248 RVA: 0x00267730 File Offset: 0x00265930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapCoordinates(MapCoordinates other)
		{
		}

		// Token: 0x060089B1 RID: 35249 RVA: 0x00267740 File Offset: 0x00265940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapCoordinates Clone()
		{
			return null;
		}

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x060089B2 RID: 35250 RVA: 0x00267750 File Offset: 0x00265950
		// (set) Token: 0x060089B3 RID: 35251 RVA: 0x00267760 File Offset: 0x00265960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x060089B4 RID: 35252 RVA: 0x00267770 File Offset: 0x00265970
		// (set) Token: 0x060089B5 RID: 35253 RVA: 0x00267780 File Offset: 0x00265980
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

		// Token: 0x060089B6 RID: 35254 RVA: 0x00267790 File Offset: 0x00265990
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060089B7 RID: 35255 RVA: 0x002677A0 File Offset: 0x002659A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapCoordinates other)
		{
			return true;
		}

		// Token: 0x060089B8 RID: 35256 RVA: 0x002677B0 File Offset: 0x002659B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060089B9 RID: 35257 RVA: 0x002677C0 File Offset: 0x002659C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060089BA RID: 35258 RVA: 0x002677D0 File Offset: 0x002659D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060089BB RID: 35259 RVA: 0x002677E0 File Offset: 0x002659E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060089BC RID: 35260 RVA: 0x002677F0 File Offset: 0x002659F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060089BD RID: 35261 RVA: 0x00267800 File Offset: 0x00265A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapCoordinates other)
		{
		}

		// Token: 0x060089BE RID: 35262 RVA: 0x00267810 File Offset: 0x00265A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060089BF RID: 35263 RVA: 0x00267820 File Offset: 0x00265A20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060089C0 RID: 35264 RVA: 0x00267830 File Offset: 0x00265A30
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapCoordinates()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_73;
					case 3:
						return;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
				}
				IL_73:
				MapCoordinates._parser = new MessageParser<MapCoordinates>(() => null);
				num = 3;
			}
		}

		// Token: 0x060089C1 RID: 35265 RVA: 0x00267900 File Offset: 0x00265B00
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool k9em98Jd6rWHCYaKTRLy()
		{
			return true;
		}

		// Token: 0x060089C2 RID: 35266 RVA: 0x00267908 File Offset: 0x00265B08
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapCoordinates HhmLqJJdLlESILpAUNy5()
		{
			return null;
		}

		// Token: 0x040032B4 RID: 12980
		private static readonly MessageParser<MapCoordinates> _parser;

		// Token: 0x040032B5 RID: 12981
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032B6 RID: 12982
		public const int WorldXFieldNumber = 1;

		// Token: 0x040032B7 RID: 12983
		private int worldX_;

		// Token: 0x040032B8 RID: 12984
		public const int WorldYFieldNumber = 2;

		// Token: 0x040032B9 RID: 12985
		private int worldY_;

		// Token: 0x040032BA RID: 12986
		internal static MapCoordinates EfCqqyJdyWo5BS2qdc4P;
	}
}

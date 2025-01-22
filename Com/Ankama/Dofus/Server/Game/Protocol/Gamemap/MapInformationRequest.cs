using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x02000586 RID: 1414
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapInformationRequest : IMessage<MapInformationRequest>, IMessage, IEquatable<MapInformationRequest>, IDeepCloneable<MapInformationRequest>, IBufferMessage
	{
		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06004417 RID: 17431 RVA: 0x001F5E0C File Offset: 0x001F400C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MapInformationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06004418 RID: 17432 RVA: 0x001F5E1C File Offset: 0x001F401C
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

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06004419 RID: 17433 RVA: 0x001F5E2C File Offset: 0x001F402C
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

		// Token: 0x0600441A RID: 17434 RVA: 0x001F5E3C File Offset: 0x001F403C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapInformationRequest()
		{
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x001F5E4C File Offset: 0x001F404C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapInformationRequest(MapInformationRequest other)
		{
		}

		// Token: 0x0600441C RID: 17436 RVA: 0x001F5E5C File Offset: 0x001F405C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapInformationRequest Clone()
		{
			return null;
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x0600441D RID: 17437 RVA: 0x001F5E6C File Offset: 0x001F406C
		// (set) Token: 0x0600441E RID: 17438 RVA: 0x001F5E7C File Offset: 0x001F407C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MapId
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

		// Token: 0x0600441F RID: 17439 RVA: 0x001F5E8C File Offset: 0x001F408C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004420 RID: 17440 RVA: 0x001F5E9C File Offset: 0x001F409C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapInformationRequest other)
		{
			return true;
		}

		// Token: 0x06004421 RID: 17441 RVA: 0x001F5EAC File Offset: 0x001F40AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004422 RID: 17442 RVA: 0x001F5EBC File Offset: 0x001F40BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004423 RID: 17443 RVA: 0x001F5ECC File Offset: 0x001F40CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004424 RID: 17444 RVA: 0x001F5EDC File Offset: 0x001F40DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004425 RID: 17445 RVA: 0x001F5EEC File Offset: 0x001F40EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004426 RID: 17446 RVA: 0x001F5EFC File Offset: 0x001F40FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapInformationRequest other)
		{
		}

		// Token: 0x06004427 RID: 17447 RVA: 0x001F5F0C File Offset: 0x001F410C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004428 RID: 17448 RVA: 0x001F5F1C File Offset: 0x001F411C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004429 RID: 17449 RVA: 0x001F5F2C File Offset: 0x001F412C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapInformationRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_5E;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						continue;
					}
					MapInformationRequest._parser = new MessageParser<MapInformationRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 == 0)
					{
						num2 = 1;
					}
				}
				IL_5E:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 2;
			}
		}

		// Token: 0x0600442A RID: 17450 RVA: 0x001F5FFC File Offset: 0x001F41FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HmnJ62OY2Na5X3i0Fy3e()
		{
			return true;
		}

		// Token: 0x0600442B RID: 17451 RVA: 0x001F6004 File Offset: 0x001F4204
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapInformationRequest ocYTXQOYEPXjcQ302nQT()
		{
			return null;
		}

		// Token: 0x04001769 RID: 5993
		private static readonly MessageParser<MapInformationRequest> _parser;

		// Token: 0x0400176A RID: 5994
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400176B RID: 5995
		public const int MapIdFieldNumber = 1;

		// Token: 0x0400176C RID: 5996
		private int mapId_;

		// Token: 0x0400176D RID: 5997
		private static MapInformationRequest Tc4IikOY9dFatAEcVihp;
	}
}

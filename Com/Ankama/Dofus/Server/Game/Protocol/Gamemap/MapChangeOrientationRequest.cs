using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x0200057A RID: 1402
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapChangeOrientationRequest : IMessage<MapChangeOrientationRequest>, IMessage, IEquatable<MapChangeOrientationRequest>, IDeepCloneable<MapChangeOrientationRequest>, IBufferMessage
	{
		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x0600437D RID: 17277 RVA: 0x001F519C File Offset: 0x001F339C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MapChangeOrientationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x0600437E RID: 17278 RVA: 0x001F51AC File Offset: 0x001F33AC
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

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x0600437F RID: 17279 RVA: 0x001F51BC File Offset: 0x001F33BC
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

		// Token: 0x06004380 RID: 17280 RVA: 0x001F51CC File Offset: 0x001F33CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapChangeOrientationRequest()
		{
		}

		// Token: 0x06004381 RID: 17281 RVA: 0x001F51DC File Offset: 0x001F33DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapChangeOrientationRequest(MapChangeOrientationRequest other)
		{
		}

		// Token: 0x06004382 RID: 17282 RVA: 0x001F51EC File Offset: 0x001F33EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapChangeOrientationRequest Clone()
		{
			return null;
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06004383 RID: 17283 RVA: 0x001F51FC File Offset: 0x001F33FC
		// (set) Token: 0x06004384 RID: 17284 RVA: 0x001F5210 File Offset: 0x001F3410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Direction Direction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Direction)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06004385 RID: 17285 RVA: 0x001F5220 File Offset: 0x001F3420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x001F5230 File Offset: 0x001F3430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapChangeOrientationRequest other)
		{
			return true;
		}

		// Token: 0x06004387 RID: 17287 RVA: 0x001F5240 File Offset: 0x001F3440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004388 RID: 17288 RVA: 0x001F5250 File Offset: 0x001F3450
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x001F5260 File Offset: 0x001F3460
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x001F5270 File Offset: 0x001F3470
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600438B RID: 17291 RVA: 0x001F5280 File Offset: 0x001F3480
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600438C RID: 17292 RVA: 0x001F5290 File Offset: 0x001F3490
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapChangeOrientationRequest other)
		{
		}

		// Token: 0x0600438D RID: 17293 RVA: 0x001F52A0 File Offset: 0x001F34A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600438E RID: 17294 RVA: 0x001F52B0 File Offset: 0x001F34B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x001F52C0 File Offset: 0x001F34C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapChangeOrientationRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					MapChangeOrientationRequest._parser = new MessageParser<MapChangeOrientationRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x001F538C File Offset: 0x001F358C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yPgZtFOHqlkFGH9RGWi8()
		{
			return true;
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x001F5394 File Offset: 0x001F3594
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapChangeOrientationRequest sWqF55OHF3mBZGKJpLJ2()
		{
			return null;
		}

		// Token: 0x04001741 RID: 5953
		private static readonly MessageParser<MapChangeOrientationRequest> _parser;

		// Token: 0x04001742 RID: 5954
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001743 RID: 5955
		public const int DirectionFieldNumber = 1;

		// Token: 0x04001744 RID: 5956
		private Direction direction_;

		// Token: 0x04001745 RID: 5957
		internal static MapChangeOrientationRequest APw41AOHZXO09lwVk4uc;
	}
}

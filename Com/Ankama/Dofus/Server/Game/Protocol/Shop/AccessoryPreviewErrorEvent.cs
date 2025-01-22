using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Shop
{
	// Token: 0x0200015C RID: 348
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AccessoryPreviewErrorEvent : IMessage<AccessoryPreviewErrorEvent>, IMessage, IEquatable<AccessoryPreviewErrorEvent>, IDeepCloneable<AccessoryPreviewErrorEvent>, IBufferMessage
	{
		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000FFF RID: 4095 RVA: 0x0019DA68 File Offset: 0x0019BC68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AccessoryPreviewErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x0019DA78 File Offset: 0x0019BC78
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

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x0019DA88 File Offset: 0x0019BC88
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

		// Token: 0x06001002 RID: 4098 RVA: 0x0019DA98 File Offset: 0x0019BC98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccessoryPreviewErrorEvent()
		{
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0019DAA8 File Offset: 0x0019BCA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccessoryPreviewErrorEvent(AccessoryPreviewErrorEvent other)
		{
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x0019DAB8 File Offset: 0x0019BCB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccessoryPreviewErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x0019DAC8 File Offset: 0x0019BCC8
		// (set) Token: 0x06001006 RID: 4102 RVA: 0x0019DADC File Offset: 0x0019BCDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AccessoryPreviewErrorEvent.Types.AccessoryPreviewError Error
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (AccessoryPreviewErrorEvent.Types.AccessoryPreviewError)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0019DAEC File Offset: 0x0019BCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0019DAFC File Offset: 0x0019BCFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AccessoryPreviewErrorEvent other)
		{
			return true;
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x0019DB0C File Offset: 0x0019BD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0019DB1C File Offset: 0x0019BD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x0019DB2C File Offset: 0x0019BD2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0019DB3C File Offset: 0x0019BD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0019DB4C File Offset: 0x0019BD4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0019DB5C File Offset: 0x0019BD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AccessoryPreviewErrorEvent other)
		{
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0019DB6C File Offset: 0x0019BD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x0019DB7C File Offset: 0x0019BD7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x0019DB8C File Offset: 0x0019BD8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AccessoryPreviewErrorEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AccessoryPreviewErrorEvent._parser = new MessageParser<AccessoryPreviewErrorEvent>(() => null);
					num2 = 3;
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0019DC58 File Offset: 0x0019BE58
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EM1KewOUtnLkNXLY23Dm()
		{
			return true;
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x0019DC60 File Offset: 0x0019BE60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AccessoryPreviewErrorEvent bn3XcyOUwSD02oj4M4gU()
		{
			return null;
		}

		// Token: 0x040005D4 RID: 1492
		private static readonly MessageParser<AccessoryPreviewErrorEvent> _parser;

		// Token: 0x040005D5 RID: 1493
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005D6 RID: 1494
		public const int ErrorFieldNumber = 1;

		// Token: 0x040005D7 RID: 1495
		private AccessoryPreviewErrorEvent.Types.AccessoryPreviewError error_;

		// Token: 0x040005D8 RID: 1496
		internal static AccessoryPreviewErrorEvent MI8gmGOUD2NUb1XxPoQL;

		// Token: 0x0200015D RID: 349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06001014 RID: 4116 RVA: 0x002ACF98 File Offset: 0x002AB198
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200015E RID: 350
			public enum AccessoryPreviewError
			{
				// Token: 0x040005DA RID: 1498
				[OriginalName("ERROR")]
				Error,
				// Token: 0x040005DB RID: 1499
				[OriginalName("COOL_DOWN")]
				CoolDown,
				// Token: 0x040005DC RID: 1500
				[OriginalName("BAD_ITEM")]
				BadItem
			}
		}
	}
}
